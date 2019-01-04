#!/bin/bash

echo SOURCE BRANCH IS %BUILD_SOURCEBRANCH%
if [%BUILD_SOURCEBRANCH% == refs/heads/master]; then 
   echo Building master branch so no merge is needed.
   exit
else
   echo merge
fi

set sourceBranch=origin/%BUILD_SOURCEBRANCH:refs/heads/=%
echo GIT CHECKOUT MASTER
git checkout master
echo GIT STATUS
git status
echo GIT MERGE
git merge %sourceBranch% -m "Merge to master"
echo GIT STATUS
git status
echo GIT PUSH
git push origin
echo GIT STATUS
git status