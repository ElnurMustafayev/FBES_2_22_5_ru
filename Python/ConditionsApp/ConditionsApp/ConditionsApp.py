#number = 9

# int float str bool
#print(type(number > 0))
#print(number < 0)

#print(10 > 10)
#print(5 > 2 + 6)

#number = 8
#print(10 + 3 > 20 - number)

#print(5 >= 5)
#print(10 <= 20)
#print(5 <= 10 - 5)

#print(123 == 123)
#print(123 != 123)

#num = 10
#print(num == 12)


#num = 10 / 2
#print(num == 5)


#result = 10 > 123
#print(result)


#print("test " == " test")
#print(10.5 > 10.5 + 1)



#text = input()
#num = 123
#floatNum = 12.5
#condition = False


#check = True

#print(check != True)
#print(check != (10 > 5))
#print(((15 == 10) != check) != (check == check))



#age = int(input("Input your age: "))
#isAdult = age >= 18

#print(isAdult)


#num1 = float(input("Input the first number: "))
#num2 = float(input("Input the second number: "))

#isEqual = num1 == num2

#print(isEqual)



#check = 456
##message = f"Result is: {check}"
#print("Result is: *", check, "*")
#print(f"Result is: *{check}*")



# money = 1000 (by default)

# "How much to add?" (example: 100)

# "Your money: 1100$"




#money = 1000.
#moneyToAdd = float(input("How much to add? "))
#money += moneyToAdd

#print(f"Your money: {money}$")

#print(money)



# 3 numbers

# count of number which are better than 0

#num1 = float(input("input 1 number: "))
#num2 = float(input("input 2 number: "))
#num3 = float(input("input 3 number: "))

#positivesCount = (num1 > 0) + (num2 > 0) + (num3 > 0)

#print(f"Cout of positive numbers: {positivesCount}")



#name = "Elnur"
#surname = "Mustafayev"

#print(f"Your name is "{name}" "{surname}"")
#print(f'Your name is "{name}" "{surname}"')




#print("Content \n here..." + ("\n" * 3))
#print("Content \t here...")
#print("Content \a here...")

#print("test \\\\test...")







#print(isAdult)
#print("Succes, you are adult!")
#print("Error, access denied!")


# if, else

# if condition:

#condition = True

#if condition:
#    print("one")
#    print("two")
#    print("three")

#print("four")
#print("five")


#number = float(input("Input the number: "))

#if number > 0:
#    print(f"{number} is positive!")




# if age >= 18 -> "Success, you are adult!"
# else "Error, access denied!"




#age = int(input("Input your age: "))

#isAdult = age >= 18

#if isAdult:
#    money = 123.6
#    money += 16.4
#    print("Success, you are adult!")
#    name = input("Name: ")
#    surname = input("Surname: ")
#    print(f"Welcome, {name} {surname}")
#    print(f"Money: {money}$")

#if isAdult == False:
#    print("Error, access denied!")




#number = int(input("Input your number: "))

## even:     / 2 = 0
## odd:      / 2 = 1

#isEven = number % 2 == 0

#if isEven == True:
#    print("Even")
#if isEven == False:
#    print("Odd")




#number = 123

#if number:
#    print("Test")

#print(bool(0))





#if bool(10) == True:
#    print("one")

#    if 10 != bool(True):
#        print("two")


#name = "Alex is"

#if name == "Al exis":
#    print(f"Hi, {name}")

#print("A" > "a")




#if True:
#    print("1")
#if False == False:
#    if True:
#        print("2")



#age = int(input("Input your age: "))
#gender = input('Enter "y" if you are male, else "n": ')

#isSuccess = (gender == "y") + (age >= 18)

#if isSuccess == 2:
#    print("Welcome!")
#if isSuccess != 2:
#    print("Goodbye!")



#if gender != "y":
#    print("Goodbye, girl!")

#if gender == "y":
#    if age >= 18:
#        print("Welcome, man!")
#    if age < 18:
#        print("Goodbye, baby!")



# and or not


#hasVisa = True
#money = 54500.5
#canGo = hasVisa and money >= 40000

#if canGo:
#    print("Can go to USA!")
#    nucasbc = 328952




#successLogin = "stepguest"
#successPassword = "guest8877"

#login = input("Input you login: ")
#password = input("Input you password: ")

#successLogined = login == successLogin and password == successPassword

#if successLogined:
#    print("Welcome")

#if not(successLogined):
#    print("Bad credentials")





#condition = bool(1232352423 % 2)
#print(condition)



#clientName = input("Input client's name: ")
#clientCountry = input("Input client's country: ")

#if clientName == "Usama" or clientCountry == "Sirya":
#    print(f"{clientName} is Terrorist!!!")


# (!) > -100
# negative, even


#num = int(input())

#isNegative = num < 0
#isEven = num % 2 == 0

#isSuccess = (isNegative or isEven) and num > -100

#if isSuccess:
#    print("success")
#if not(isSuccess):
#    print("error")


# if elif else

#condition = 10 < 5



#age = int(input("Input your age: "))

#if age >= 18:
#    print("Adult!")
#else:
#    print("Access denied!")



#check = True

#if check:
#    print("IF")
#    check = False
#    print(check)
#else:
#    print(check)

#print(check)


#print("Start")
#num = 0
#condition = True

#while condition:
#    num += 1
#    print(num)
#    condition = not(condition)

#print("End")


#print("Start")
#counter = 0

#while counter < 3:
#    counter += 1
#    print(f"{counter} Iteration")

#print("End")







#counter = 0

#while counter <= 5:
#    print(counter)
#    counter += 1



# 5:    0,1,2,3,4,5
# -5:   -5,-4,-3,-2,-1,0

#num = int(input("Input the number: ")) # 3
#counter = 0
#condition = True

##positive
#if num > 0:
#    while counter <= num:
#        print(counter)
#        counter += 1
## negative
#else:
#    while num <= 0:
#        print(num)
#        num += 1




# 5: 0,1,2,3,4,5
# -5: -5,-4,-3,-2,-1,0
#num = int(input("Input the number: ")) # 5

## positive
#if num > 0:
#    start = 0
#    end = num
## negative
#else:
#    start = num
#    end = 0

#while start != (end + 1):
#    print(start)
#    start += 1





# 5: 0,1,2,3,4,5
# -5: -5,-4,-3,-2,-1,0

#num = int(input("Input the number: ")) # 5
#history = num

#while True:
#    if num > 0:
#        print(num - history)
#    else:
#        print(num)
#    num+=1




# 123: 0 - 123


#num = int(input("Input the number: "))
#counter = 0

#while counter != num and counter < 100:
#    counter += 1
#    print(counter)


#counter = 0

#while counter != 4:
#    counter+=1
#    print(counter)

#print("start")

#counter = 0

#while True:
#    counter+=1
#    print(counter)
#    if counter == 4:
#        break

#print("end")


#print("start")

#counter = 0

#while True:
#    print(counter)
#    counter += 1

#    if not(counter % 5):
#        break

#print("end")




#num = int(input("Input the number: "))

#while True:
#    isOdd = num % 2 == 1

#    if isOdd:
#        num-=1
#        continue

#    print(num)
#    num-=1

#    if num < 0:
#        break






# 97:
# 1,2,3,4,5,6,7,8,9,
# 11,12,13,14,15,16,17,18,19
# ...
# 91,92,93,94,95,96,97

#num = int(input("Input the number: "))
#counter = 0

#while True:
#    if counter >= num:
#        break

#    counter += 1

#    if counter % 10 == 0:
#        continue

#    print(counter)