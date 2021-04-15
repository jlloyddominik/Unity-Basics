# Unity-Basics

This project covers basic concepts in C# and Unity Development.


## Accessing the Repo:
I prefer command line tools to GUI tools when it comes to doing git stuff. When on Windows I use Git For Windows (I think it went by GitBash when I first downloaded it). On Mac I use terminal. On Linux you'd use command line/terminal (whatever it's called).

The advantage of command line is solutions are text-based. When you run in to an issue, the solution is a series of text commands. There's non of the ambiguity of dealing with a GUI interface. I also find that solutions to problems in text-based git are more readily available on sites like stack overflow.

The one thing I feel you miss out on is visualisation of the repo's branch structure. Many GUIs have built in terminals/command lines. I'd still recommend spending some time on command line first. If you need to visualise your project's branch structure, GitHub has tools in the Insights Tab.

Git for Windows: https://gitforwindows.org/

Command Line git is run using the following basic structure: git "command" "arguments/flags". The command is the command you're performing. Arguments are 

### Bash Commands (use to do non-git stuff in your terminal):

cd *path*: change directory (folder) - move to a directory given the path
examples:
- cd: moves to your root directory
- cd ..: moves back up one level in the directory (current directory's parent directory)
- cd Desktop/BTG: moves from root directory to BTG folder on my desktop (must be in root direction)
- cd ~/*path*: the tilde (~) represents the root directory, so you can put this in a path to move to a directory relative to th root

ls: list directory contents: Shows files and folders in the current directory

### Important Basic Commands:

git clone *repo url*: Takes an existing repo (from GitHub or elsewhere) and clones (downloads) it to the current place in the directory

NOTE: the rest is important for modifying the repo but we won't cover this now

git add *arguments* 
examples:
- git add . : adds all changes to the next commit
- git add *relative path to folder*: adds all changes in the folder to the next commit
- git add *relative path to file*: adds changes to a specific file to the next commit

git commit -m "*commit message*": makes a commit with all the changes you've added with git add. If you add stuff after, they will go in the next commit

git push: pushes your local version of the branch to the origin (GitHub etc)

git pull: pulls in origin version of branch to local
