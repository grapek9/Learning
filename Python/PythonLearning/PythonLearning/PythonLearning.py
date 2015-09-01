#print("Project euler Problem1")
#list=list(range(1,1001))
#sum = 0 ;
#for i in range(len(list)):
#    if (i%3 == 0) | (i%5==0):
#       sum+= i   
#print(sum)

#print("Project Euler Problem2")
#argument1 = 1;
#argument2 = 1;
#temp = 0;
#sum = 0;
#while (argument2 <4000000):
#    temp = argument2
#    argument2 = argument1+argument2
#    argument1 = temp
#    if(argument2%2==0):
#        sum+=argument2
#
#print(sum)

print("Project Euler Problem3")
def isPrime(number:int):
    for i in range(1,number):
        if(number%i==0):
            return False 
    return True
value = 600851475143;
max = 0
iteration  = 2
while(value > 1):
    if(isPrime(iteration)!=True):
        if(value%iteration==0):           
            value /= iteration
            max = iteration
    iteration = iteration + 1
print(max)
