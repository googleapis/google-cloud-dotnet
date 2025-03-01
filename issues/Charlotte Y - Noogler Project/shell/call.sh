# Copyright 2025 Google Inc. All Rights Reserved.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

# Check for the correct number of arguments
if [ $# -lt 1 ]; then
  echo "Usage: $0 <operation>"
  echo "  <operation>: 'create-todo', 'update-todo', 'read-todos', or 'delete-todo'"
  return
fi

# Check if ID_TOKEN environment variable is set
if [ -z "$ID_TOKEN" ]; then
  echo "Error: Missing ID Token."
  echo "Run: source authenticate.sh"
  return
fi

# Assign arguments to variables
OPERATION="$1"
# Initialize the request body
BODY="{\"idToken\": \"$ID_TOKEN\""

# Form the request body according to the operation and user response
case "$OPERATION" in
  create-todo)
    read -p "Enter title: " TITLE
    if [ -n "$TITLE" ]; then
      BODY+=", \"title\": \"$TITLE\""
    else
      echo "Error: Title is required"
      return
    fi

    read -p "Enter description: " DESCRIPTION
    if [ -n "$DESCRIPTION" ]; then
      BODY+=", \"description\": \"$DESCRIPTION\""
    else
      echo "Error: Description is required"
      return
    fi

    read -p "[Optional] Enter priority (1-5): " PRIORITY
    if [ -n "$PRIORITY" ]; then
      BODY+=", \"priority\": $PRIORITY"
    fi

    read -p "[Optional] Enter status (NotStarted, InProgress, Completed): " STATUS
    if [ -n "$STATUS" ]; then
      BODY+=", \"status\": \"$STATUS\""
    fi
    ;;
  read-todos)
    read -p "[Optional] Enter task ID: " TASK_ID
    if [ -n "$TASK_ID" ]; then
      BODY+=", \"taskId\": \"$TASK_ID\""
    fi

    read -p "[Optional] Enter priority (1-5): " PRIORITY
    if [ -n "$PRIORITY" ]; then
      BODY+=", \"priority\": $PRIORITY"
    fi

    read -p "[Optional] Enter status (NotStarted, InProgress, Completed): " STATUS
    if [ -n "$STATUS" ]; then
      BODY+=", \"status\": \"$STATUS\""
    fi
    ;;
  update-todo)
    read -p "Enter task ID: " TASK_ID
    if [ -n "$TASK_ID" ]; then
      BODY+=", \"taskId\": \"$TASK_ID\""
    else
      echo "Error: Task ID is required"
      return
    fi

    read -p "[Optional] Enter new title: " TITLE
    if [ -n "$TITLE" ]; then
      BODY+=", \"title\": \"$TITLE\""
    fi

    read -p "[Optional] Enter new description: " DESCRIPTION
    if [ -n "$DESCRIPTION" ]; then
      BODY+=", \"description\": \"$DESCRIPTION\""
    fi

    read -p "[Optional] Enter new priority (1-5): " PRIORITY
    if [ -n "$PRIORITY" ]; then
      BODY+=", \"priority\": $PRIORITY"
    fi

    read -p "[Optional] Enter new status (NotStarted, InProgress, Completed): " STATUS
    if [ -n "$STATUS" ]; then
      BODY+=", \"status\": \"$STATUS\""
    fi
    ;;
  delete-todo)
    read -p "Enter task ID: " TASK_ID
    if [ -n "$TASK_ID" ]; then
      BODY+=", \"taskId\": \"$TASK_ID\""
    else
      echo "Error: Task ID is required"
      return
    fi
    ;;
  *)
    echo "Error: Invalid operation '$OPERATION'"
    echo "Valid operations are: create-todo, update-todo, read-todos, delete-todo"
    return
    ;;
esac

BODY+="}"
echo

# Validate that BODY is a valid JSON object (basic check)
if ! echo "$BODY" | jq empty >/dev/null 2>&1; then
  echo "Error: Invalid JSON body"
  return
fi

# Construct gcloud command
REGION="us-west1"

GCLOUD_COMMAND=(
  gcloud
  functions
  call
  "$OPERATION"
  --region="$REGION"
  --data="$BODY"
)

# Execute the gcloud command
GCLOUD_RESPONSE=$("${GCLOUD_COMMAND[@]}")

# Check for errors
if [ $? -ne 0 ]; then
  echo "Error: gcloud functions call failed"
  echo "gcloud output: $GCLOUD_RESPONSE"
  return
fi

# Print the gcloud command output
echo "$GCLOUD_RESPONSE"

return
