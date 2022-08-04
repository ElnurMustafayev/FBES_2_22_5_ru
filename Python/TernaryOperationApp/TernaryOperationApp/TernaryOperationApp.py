# and or

#if False and 10 > 5:
#    print("YES")

#if True or ((100 - 123) < 0):
#    print("YES")



#moneyUsd = float(input("Input your money (USD): "))
#moneyAzn = 0

#if moneyUsd > 0:
#    moneyAzn = moneyUsd * 1.7

#print(f"Your money in USD: {moneyUsd}$")
#print(f"Your money in AZN: {moneyAzn}m")




# age
# isAdult
# message ("User is Adult" / "DANGER! USER IS NOT ADULT!!!")
# isVeryOld


#age = int(input("Input your age: "))

#if age >= 18:
#    isAdult = True
#else:
#    isAdult = False


#if isAdult:
#    message = "User is Adult"
#else:
#    message = "DANGER! USER IS NOT ADULT!!!"

#isAdult = age >= 18

#message = "User is Adult" if age >= 18 else "DANGER! USER IS NOT ADULT!!!"

#isVeryOld = True if age >= 100 else False

#print(isVeryOld)





#var = "test" if False else 123


#num = ((10 if False else 13) if True else 13)
#print(num)

#condition = True
#counter = 0
#while (3 >= (counter if condition else 0)):
#    print("iteration")
#    counter+=1
#    condition = not(condition)




#num = int(input("Input the number: "))
#counter = 0


#while True:
#    counter+=1

#    if counter % 5 == 0:
#        continue

#    print(counter)

#    if counter >= num:
#        break