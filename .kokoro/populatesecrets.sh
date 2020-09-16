#!/bin/bash

declare -r SECRETS_LOCATION="${KOKORO_GFILE_DIR}/secret_manager"

# Populates secrets from Secret Manager according
# to what's specified on env variables.
populate_all_secrets(){
    echo "Creating folder on disk for secrets: ${SECRETS_LOCATION}"
    mkdir -p ${SECRETS_LOCATION}
    for key in $(echo ${COMMON_SECRETS} | sed "s/,/ /g")
    do
      echo "Retrieving secret ${key}"
      gcloud secrets versions access latest \
        --project cloud-sharp-jenkins \
        --secret $key > \
        "${SECRETS_LOCATION}/$key"
      if [[ $? == 0 ]]; then
        echo "Secret written to ${SECRETS_LOCATION}/${key}"
      else
        echo "Error retrieving secret ${key}"
      fi
    done
}
