#try - except

#print("Start")

#try:
#    num = int(input("Number: "))
#    print(123 / num)
#    print(num)
#except ZeroDivisionError as error:
#    print("Num can not be zero!")
#    print(error)
#except ValueError as ex:
#    print("Incorrect data!")
#    print(ex)

#print("End")





#def InfRecursion(num):
#    num = int(input())
#    InfRecursion(123 / num)

#try:
#    InfRecursion(123)
#except RecursionError as error:
#    print(error)
#except ValueError as error:
#    print(error)
#except Exception as error:
#    print(type(error))
#    print(f"Default Error: {error}")



#def InputUserAge():
#    try:
#        age = int(input("Age: "))
#        return age >= 18
#    except Exception as ex:
#        print(ex)
#        return False


#print(InputUserAge())




def PrintAllElements(arr):
    counter = 0

    while True:
        try:
            print(arr[counter])
            counter += 1
        except:
            break


nums = [1,2,3]
PrintAllElements(nums)