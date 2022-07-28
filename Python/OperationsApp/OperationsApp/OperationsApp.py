#name = input("Input your name: ")

#print("Your name is: " + name)


#print("Hello World" + "!")
#num = 500
#num = 124 / 2

#print(type(num))

#print(123 + 1)
#print(num + 1)
#print(num - 1)
#print(100 * 2)
#print(100 / 2)

#print(type(100 / 2))



#num = (2 + 2) * 2 + 3       # 11
#print(num)


#print(type((1.0 * 4)))




#num1 = 100
#num2 = 50.2

#print(num1 + num2)




# print(5 % 3)      # 2

#num = 100
#num = 23 % 3
#print(num + 5)     # 7

#num = 100
#power = 6
#print(num ** power)

#print(2 ** 4)       # 16

#print(100 / 3)      # 33.333...
#print(100 // 3)     # 33







#num = 100

#print(num + 1)     # 101
#print(num)         # 100


#num = num + 5
#num = num + 5
#num = num + 5
#num = num + 5
#num = num + 5
#print(num)



#num = 100

#num = num + 1
#num += 1

#print(num)


#num *= 2
#num / 10
#num += 15
#print(num)



#num = 5

#num **= 2
#num %= 6
#num += num

#print(num)



#num = 5
#num *= num * 2
#num /= 10 // 3
#print(num)



#age = input()
#varType = type(age)
#print(varType)

#age = input("input your age: ")

#print(int(age) + 10)

#print(type(age))            # str




#condition = True

#if condition:
#    print("IF")
#    condition = not(condition)
#if condition:
#    print("IF")
#else:
#    print("ELSE")






#if True:
#    print("TRUE")
#if not(1):
#    print("1")
#else:
#    print("2")
#    if True:
#        print("3")
#else:
#  print(False)
















# currencies (3 default)
# courses 
# select


#money = float(input("Input your money in AZN: "))

#print("Currencies: \n\n")

#USD = 0
#EUR = 1.78
#RUB = 0.029
#result = -1

#print("Press")
#if USD != 0:
#    print(f"'a' for USD - {USD}")
#if EUR != 0:
#    print(f"'b' for EUR - {EUR}")
#if RUB != 0:
#    print(f"'c' for RUB - {RUB}")

#userSelect = input("Select course to convert: ")

#if (userSelect == "a" or userSelect == "A") and USD != 0:
#    result = round(money / USD, 2)
#elif (userSelect == "b" or userSelect == "B") and EUR != 0:
#    result = round(money / EUR, 2)
#elif (userSelect == "c" or userSelect == "C") and RUB != 0:
#    result = round(money / RUB, 2)
#else:
#    print("Error")

#if result != -1:
#    print(result)





# -100 0        this number is little
# -inf -100     this number is very little

# 0 100         this number is high
# 100 inf       this number is very high

# 0             this number is zero



#number = int(input("Input the number: "))

## CHECK FOR ZERO
#if number == 0:
#    print("this number is zero")

## CHECK FOR LITTLE
##if number >= -100 and 0 > number:
#elif 0 > number >= -100:
#    print("this number is little")
#elif number < -100:
#    print("this number is very little")

## CHECK FOR HIGH
##elif number > 0 and number <= 100:
#elif 0 < number <= 100:
#    print("this number is high")
#elif number > 100:
#    print("this number is very high")




#import random

#randFloatStr = float(f"{random.randint(0, 100)}.{random.randint(10, 99)}")
#print(randFloatStr)

#print(random.randint(0, 100))