import math
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

#print("Project Euler Problem3")
#def isPrime(number:int):
#    for i in range(2,number):
#        if(number%i==0):
#            return True 
#    return False
#value = 600851475143;
#max = 0
#iteration  = 2
#while(value > 1):
#    if(isPrime(iteration)==True):
#        if(value%iteration==0):           
#            value /= iteration
#            max = iteration
#    iteration = iteration + 1
#print(max)

#print("Project Euler Problem4")
#def isPalindrome(value):
#    for i in range(0,len(value)-1):
#        if(value[i]!=value[len(value)-1-i]):
#            return False
#    return True
#max = 0
#for i in range(100,999):
#    for j in range(100,999):
#        if(isPalindrome(str((i*j)))==True):
#            if((i*j)>max):
#                max = i*j
#print(max)

#print("Project Euler Problem 6")
#def sumOfSquares(number):
#    output = 0
#    for i in range(1,number+1):
#        output+=pow(i,2)
#    return output
#def squareOfSum(number):
#    output = 0
#    for i in range(1,number+1):
#        output+=i
#    return pow(output,2)
#value = 100
#print(sumOfSquares(value))
#print(squareOfSum(value))
#print(squareOfSum(value)-sumOfSquares(value))

#print("Project Euler Problem 7")
#def isPrime(number:int):
#    for i in range(2,math.floor(number/2)):
#        if(number%i==0):
#            return False
#    return True
#listOfElements=[]
#number =2
#while(len(listOfElements)!=10000):
#    if(isPrime(number)==True):
#        listOfElements.append(number)
#        print(len(listOfElements))
#    number+=1
#print(max(listOfElements))

#print("Project Euler Problem 10")

#def isPrime(number:int):
#    for i in range(2,math.floor(number/2)):
#        if(number%i==0):
#            return False
#    return True
#sum = 0
#for i in range(2,2000000):
#    if(isPrime(i)==True):
#        sum+=i
        #print(i)
#print(sum)

print("Project Euler Problem 16")
def sumator(number):
    sum=0
    for i in range(0,len(number)):
        sum+=int(number[i])
    return sum
number = int(math.pow(2,1000))
sum= sumator(str(number))
print(sum)