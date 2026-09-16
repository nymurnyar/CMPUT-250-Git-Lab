# CMPUT-250-Git-Lab

Basic project for CMPUT 250

I am adding this line so I can rebase rebase_nyar onto the main


## Extra Credit

What I did for rebase as a programmer ,

* I first went to my lab 3 branch called "nyar_branch" using `git checkout nyar_branch`
* then i used `git status` to see if i was in the correct branch
* then i branch off from that branch using `git checkout -b rebase_nyar` to my rebase_nyar branch so i can make changes there for this demo
* I added a line of comment in the `CMPUT-250-Git-Lab/Assets/moveImage.cs` file and committed it.
* Then, I went to the main branch using `git checkout main` and added the text above "I am adding this line so I can rebase rebase_nyar onto the main" in this readme and committed it .
* so now I have two different commits which are at different stages , now i can perform rebase
* I went to my rebase_nyar branch by doing `git checkout rebase_nyar`
* then i did `git rebase main` , which replayed my rebase\_nyar commits on top of main's latest commit that allowed me to have the commit that i created in main to exist in the rebase_nyar branch in a linear fashion
* the i pushed the main and the rebase_nyar branch to GitHub .
* After all that I am committing and pushing this text to the main branch.
