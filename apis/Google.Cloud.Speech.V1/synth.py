import os
from synthtool import shell
from pathlib import Path

# Parent of the script is the API-specific directory
# Parent of the API-specific directory is the apis directory
# Parent of the apis directory is the repo root
root = Path(__file__).parent.parent.parent
package = Path(__file__).parent.name

shell.run(
  f'"C:\\Program Files\\Git\\bin\\bash.exe" generateapis.sh {package}',
  cwd = root,
  hide_output = False)
