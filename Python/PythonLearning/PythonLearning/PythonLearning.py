print("Project euler Problem1")
list=list(range(1,1001))
sum = 0 ;
for i in range(len(list)):
    if (i%3 == 0) | (i%5==0):
        sum+= i   
print(sum)
