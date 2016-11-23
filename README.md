# ObsGitBranchDisplayer
(Called OGBD)
Write git branch name in a file, format is supported

# How to use
interface: https://puu.sh/srYAH/c3cb8a8cf5.png
The only required action you have to do is clicking on the first textbox and choose a file called HEAD in .git

You can choose the format of the file ({0} is being replaced by the branch name)
You can choose where to save the file that will be read by obs.

# Add in OBS Studio
In the sources: Right click => Add => Text(GDI+) => [name] => check "Read from file" => Click "Browse" => choose the file where OGBD saves.
