import json
import sys
from synthtool import shell
from synthtool import metadata
from pathlib import Path

# preare-release.sh updates synth.metadata itself
metadata.enable_write_metadata(False)
AUTOSYNTH_MULTIPLE_COMMITS = True

# Parent of the script is the API-specific directory
# Parent of the API-specific directory is the apis directory
# Parent of the apis directory is the repo root
root = Path(__file__).parent.parent.parent
package = Path(__file__).parent.name

bash = '/bin/bash'
if sys.platform == 'win32':
  bash = 'C:\\Program Files\\Git\\bin\\bash.exe'

shell.run(
  (bash, 'prepare-release.sh', 'write-service-directory'),
  cwd = root,
  hide_output = False)
