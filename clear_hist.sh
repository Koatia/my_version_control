#!/bin/bash

FILE=clear_hist.log
if test -f "$FILE"; then
	rm $FILE
fi
exec &>$FILE

echo $FILE
date
echo "Clear Git History"

for var in "git checkout --orphan temp" "git add -A" "git commit -am \"First init\"" "git branch -D main" "git branch -m main" "git push -f origin main"
do
    echo
    echo "*********************************"
    echo "Выполняется $var"
    eval $var
done

exit
