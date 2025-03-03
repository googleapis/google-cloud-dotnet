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

API_KEY="REDACTED"

# Prompt user for email and password
echo "Welcome to Todo Application. Would. you like to LOG IN (1) or SIGN UP (2)?"
read -p "Enter 1 or 2: " MODE
if [[ "$MODE" != "1" && "$MODE" != "2" ]]; then
  echo "Invalid input. Please enter 1 or 2."
  return
fi
read -p "Enter email: " EMAIL
read -s -p "Enter password: " PASSWORD
echo

if [ "$MODE" == "2" ]; then
  # Perform the signup request
  SIGNUP_RESPONSE=$(curl -s -X POST \
    "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=$API_KEY" \
    -H "Content-Type: application/json" \
    -d "{
      \"email\": \"$EMAIL\",
      \"password\": \"$PASSWORD\"
    }")
  # Check for errors in the sign up response
  if echo "$SIGNUP_RESPONSE" | grep -q "error"; then
    echo "Error: Sign Up failed."
    echo "Detailed error message: $(echo "$SIGNUP_RESPONSE" | jq -r '.error.message')"
    return
  fi
fi

# Perform the login request
RESPONSE=$(curl -s -X POST \
  "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=$API_KEY" \
  -H "Content-Type: application/json" \
  -d "{
    \"email\": \"$EMAIL\",
    \"password\": \"$PASSWORD\",
    \"returnSecureToken\": true
  }")

# Check for errors in the login response
if echo "$RESPONSE" | grep -q "error"; then
  echo "Error: Log In failed."
  echo "Detailed error message: $(echo "$RESPONSE" | jq -r '.error.message')"
  return
fi

# Extract the ID token
ID_TOKEN=$(echo "$RESPONSE" | jq -r '.idToken')

# Check if id token is empty
if [ -z "$ID_TOKEN" ]; then
  echo "Error: Could not extract ID token from response."
  echo "Raw response: $RESPONSE"
  return
fi

# export the id token as an environment variable
export ID_TOKEN
echo 'ID Token retrieved. Log in successful.'
