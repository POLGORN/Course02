import math

print('В какую меру вы хотите перевести, радиальную или градусную?(Р/Г):')
alpha = input()
print('Введите значение:(в дробном значении должна ставиться ТОЧКА, а не запятая)')
beta = input()

if alpha == 'Г':
    print('Результат:', float(beta)*180/math.pi, 'градусов')
else:
    print('Результат:', float(beta)*math.pi/180, 'радиан')
