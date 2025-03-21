using DAL004;


internal class Program
{

    public static void Main(string[] args)
    {
        Repository.JSONFileName = "Celebrities.json";
        using (IRepository repository = Repository.Create("Celebrities"))
        {
            void print(string label)
            {
                Console.WriteLine("-----" + label + "-------------");
                foreach (Celebrity celebrity in repository.GetAllCelebrities())
                {
                    Console.WriteLine($"Id = {celebrity.Id}, First name = {celebrity.Firstname}," +
                        $"Surename = {celebrity.Surname}, photoPath = {celebrity.PhotoPath}");
                }
            };
            print("Start");

            int? testdel1 = repository.addCelebrity(new Celebrity(0, "TestDel1", "TestDel1", "Photo/TestDel1.jpg"));
            int? testdel2 = repository.addCelebrity(new Celebrity(0, "TestDel2", "TestDel2", "Photo/TestDel2.jpg"));

            int? testupd1 = repository.addCelebrity(new Celebrity(0, "TestUpd1", "TestUpd1", "Photo/TestUpd1.jpg"));
            int? testupd2 = repository.addCelebrity(new Celebrity(0, "TestUpd2", "TestUpd2", "Photo/TestUpd2.jpg"));

            Console.WriteLine($"\n{repository.saveChanges()} changes detected\n");
            print("add 4");
            if (testdel1 != null)
            {
                if (repository.delCelebrity((int)testdel1))
                {
                    Console.WriteLine($"Delete {testdel1}");
                }
                else
                {
                    Console.WriteLine($"Delete {testdel1} error");
                }
            }

            if (testdel2 != null)
            {
                if (repository.delCelebrity((int)testdel2))
                {
                    Console.WriteLine($"Delete {testdel2}");
                }
                else
                {
                    Console.WriteLine($"Delete {testdel2} error");
                }
            }

            if (repository.delCelebrity(1000))
            {
                Console.WriteLine($"Delete {1000}");
            }
            else
            {
                Console.WriteLine($"Delete {1000} error");
            }
            Console.WriteLine($"\n{repository.saveChanges()} changes detected\n");
            print("Del 2");

            //foreach(var celeb in repository.GetAllCelebrities())
            //{
            //    Console.WriteLine(celeb.ToString());
            //}


            if (testupd1 != null)
            {
                if (repository.updCelebrityById((int)testupd1, new Celebrity(0, "Updated1", "Updated1", "Photo/Updated1.jpg")) != -1)
                {
                    Console.WriteLine($"Update {testupd1}");
                }
                else
                {
                    Console.WriteLine($"Update {testupd1} error");
                }
            }
            if (testupd2 != null)
            {
                if (repository.updCelebrityById((int)testupd2, new Celebrity(0, "Updated2", "Updated2", "Photo/Updated2.jpg")) != -1)
                {
                    Console.WriteLine($"Update {testupd2}");
                }
                else
                {
                    Console.WriteLine($"Update {testupd2} error");
                }
            }

            if (repository.updCelebrityById(1000, new Celebrity(0, "Update 1000", "Update 1000", "Photo/Update1000.jpg")) != -1)
            {
                Console.WriteLine($"Update {1000}");
            }
            else
            {
                Console.WriteLine($"Update {1000} error");
            }

            Console.WriteLine($"\n{repository.saveChanges()} changes detected\n");

            print("Upd 2");

        }
    }
}