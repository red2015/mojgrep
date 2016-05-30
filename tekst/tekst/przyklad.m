napis = 'A = [   1 2; 4 5 ; 5 2]';
rozbij = regexp(napis, '(^[^=]*= *)(\[)([^;]*)([;\]].*)', 'Tokens');
rozbij = rozbij{1};
% co po wykonaniu powyzszego jest w kolejnych 
% komorkach tablicy _rozbij?_

rozbij2 = rozbij([1 2 3 3 4]);
rozbij2{3} = regexprep(rozbij2{3}, ' *[0-9]+ *', 'c');
% co sie stalo z trzecia komorka tablicy rozbij2?

napis2 = sprintf('%s{%s}%s%s%s', rozbij2{[1 3 2 4 5]});
% co znajduje sie w zmiennej napis2?

disp(napis2)