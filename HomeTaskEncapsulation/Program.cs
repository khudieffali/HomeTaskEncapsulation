namespace HomeTaskEncapsulation
{
    internal class Program
    {
         static void Main(string[] args)
        {
            #region Task 1
            //int[] baseArray = new[] { 2, 5, 7, 8, 9 };
            //int[] childArray = new[] { 2, 7,8 };
            //IsArrayContains(baseArray,childArray);
            #endregion

            #region Task 2

            Student student1 = new("Salvar", "Ceferov", "salvar_cafarov", "salvar123",5);
            Student student2 = new("Ali", "Xudiyev", "ali_xudiyev", "ali123",9);
            Student student3 = new("Pasha", "Allahverdiyev", "pasha_allahverdiyev", "pasha123",2);
            Student student4 = new("Ali", "Sammadov", "ali.sammad", "sammadov123",6);
            User user = new("Nicat", "Mirzeyev", "nicat.mirzeyev", "nicat123");
            Student[] stuArr = new[] {student1, student2, student3, student4};
            User[] userArr = new[] { student1, student2, student3, student4 ,user };
            student1.Login(userArr,stuArr);
            #endregion

        }

        #region Task 1
        //static void IsArrayContains(int[] baseArray, int[] childArray)
        //{
        //    int count = 0;
        //    int counter = 1;
        //    bool check=false;
        //    for (int i = 0; i < childArray.Length; i++)
        //    {
        //        for (int j = 0; j < baseArray.Length; j++)
        //        {
        //            if (childArray[i] == baseArray[j] && j>=count)
        //            {
        //                if (counter == childArray.Length)
        //                {
        //                    check = true;
        //                    break;
        //                }
        //                count = j;
        //                counter++;
        //            }
        //        }
        //    }
        //    Console.WriteLine(check);

        //}
        #endregion




    }

}