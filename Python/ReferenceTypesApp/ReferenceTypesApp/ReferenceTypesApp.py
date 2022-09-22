# swap
#nums = [1,2,3,4,5]  # [2,1,3,4,5]

#nums[0], nums[4] = nums[4], nums[0]
#temp = nums[0]      # 1
#nums[0] = nums[4]   # [5,2,3,4,5]
#nums[4] = temp      # [5,2,3,4,1]

#print(nums)

# Swap(myList, x, y)





#def Swap(collection, left, rigth):
#    isNegative = left < 0 or rigth < 0
#    isOutOfRange = left >= len(collection) or rigth >= len(collection)

#    if isOutOfRange or isNegative:
#        print(f"Incorrect index: '{left}' '{rigth}'!")

#    # swap
#    else:
#        temp = collection[left]
#        collection[left] = collection[rigth]
#        collection[rigth] = temp



#mylist = [1,2,3,4,5,6,7,8]
#Swap(mylist, 0, 1)

#print(mylist)
    



#def ChangeNumber(number):
#    number = 777

#num = 100
#ChangeNumber(num)

#print(num)




#def ChangeArr(arr):
#    arr.append("qwerty")


#nums = [1,2,3]

#ChangeArr(nums)

#print(nums)





#num1 = 100
#num2 = 200

#num1 = num2

#num2 += 123123123

#print(num1)


#nums1 = [1,2,3,4,5]
#nums2 = [5,4,3,2,1]

#nums1 = nums2

#nums1.append("test")
#print(nums1)
#print(nums2)







#def ChangeArr(arr):
#    arr[1] = "CHANGED"


#nums = [1,2,3]

#ChangeArr(nums)

#print(nums)



#num = 123

#nums = [34634,3464,4574]

#num = nums

#num.clear()

#print(nums)







#def GetArr():
#    myList = [1,2,3]

#    myList.append(True)

#    return myList

#list1 = GetArr()
#list2 = GetArr()

#list1.clear()
#print(list2)



myList = [1,2,3]

def Func():
    global myList

    myList.append(1)

    return myList

list1 = Func()
list2 = Func()

list1.clear()
print(list2)