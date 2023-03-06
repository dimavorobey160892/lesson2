// See https://aka.ms/new-console-template for more information
void Dates()
{
    DateTime dt1 = new DateTime(2023, 01, 01); //Дата початку поточного року
    DateTime dt2 = new DateTime(2024, 01, 01); //Дата початку наступного року
    int nowMonth = DateTime.Now.Month;
    int nowDay = DateTime.Now.Day;
    int preMonth = dt1.Month;
    int preDay = dt1.Day;
    int afterMonth = dt2.Month;
    int afterDay = dt2.Day;
    var dd1 = (DateTime.Now - dt1);
    var dd2 = (dt2 - DateTime.Now);
    Console.WriteLine($"Сьогодні {DateTime.Now:m}\nЧас {DateTime.Now:t}");
    Console.Write($"С {dt1:m} {m} місяця ");
    Console.WriteLine(isPassed(m) ? "Минуло" : $"Не минуло, залишилося {dd.Days} дней");
    Console.WriteLine(isPassed(m) ? "Минуло" : $"Не минуло, залишилося {dd.Days} дней");

    bool isPassed(int month)
    {
        int r = nowMonth - preMonth;
        if (r > month)
        {
            return true;
        }
        else if (r < month)
        {
            return false;
        }
        else
        {
            if (nowDay > preDay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    bool isPassed2(int month)
    {
        int r = afterMonth - nowMonth;
        if (r > month)
        {
            return true;
        }
        else if (r < month)
        {
            return false;
        }
        else
        {
            if (afterDay > nowDay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
