print("**********复杂数据类型 talbe************")
--所有的复杂类型都是table（表）
print("**********数组************")
a = {1,2,nil,3,"1231",true,nil}
--lua中 索引从1开始
print(a[1])
print(a[5])
print(a[6])
print(a[7])
--#是通用的获取长度的关键字
--在打印长度的时候 空被忽略
--如果表中（数组中）某一位变成nil 会影响#获取的长度
print(#a)

-- 数组遍历
for i=1,#a do
    print(a[i])
end

-- 二维数组
a = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
}
-- 访问单个元素
print(a[1][2])

-- 二维数组遍历
for i=1,#a do
    for j=1,#a[i] do
        print(a[i][j])
    end
end



-- 自定义索引

az = { [0] = 1,2,3,[-1] =4,5}

print(az[0])
print(az[-1])
print(#az) -- 个数算1，2，3.... 所以对于自定义的索引会不被计算进去 
-- 如果隔着几个数进行赋值，且索引在是个自然数，会取最大的索引计算数组长度，如果未设置的索引会赋值为nil
