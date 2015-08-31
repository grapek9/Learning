print("Project Euler Problem2")
argument1 = 1;
argument2 = 1;
temp = 0;
sum = 0;
while (argument2 <4000000):
    temp = argument2
    argument2 = argument1+argument2
    argument1 = temp
    if(argument2%2==0):
        sum+=agrument2

print(sum)