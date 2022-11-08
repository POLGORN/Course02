from multiprocessing import connection
import pymysql
from config import host, user, password, db_name

try:
    connection = pymysql.connect(
        host=host,
        port=3306,
        user=user,
        password=password,
        database=db_name,
        cursorclass=pymysql.cursors.DictCursor
    )
    
    print('Всё круто')
    
    try:
        with connection.cursor() as cursor:
            select_all_rows = 'SELECT * FROM tourneys'
            cursor.execute(select_all_rows)
            rows = cursor.fetchall()
            for row in rows:
                print(row)
    finally:
        connection.close()

except Exception as ex:
    print('Всё не круто')
    print(ex)
