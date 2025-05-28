namespace DAL_Celebrity_MSSQL
{
    public class Init
    {
        static string connectionString = "Server=DESKTOP-I\\SARVAR; Database=Lab6_Db; Trusted_Connection=true; TrustServerCertificate=Yes";

        public Init() { }
        public Init(string connStr) { connectionString = connStr; }

        public static void Execute(bool delete = true, bool create = true)
        {
            Context context = new Context(connectionString);
            if (delete)
            {
                context.Database.EnsureDeleted();
            }
            if (create)
            {
                context.Database.EnsureCreated();
            }
            Func<string, string> puri = (f) => $"{f}";

            {//1
                Celebrity c = new Celebrity() { FullName = "Noam Chomsky", Nationality = "US", ReqPhotoPath = puri("Chomsky.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 1, Date = new DateTime(1928, 12, 7), Description = "Дата Рождения", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 1, Date = new DateTime(1955, 1, 1), Description = "Book logic structure of linguistic theory", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }
            {//2
                Celebrity c = new Celebrity() { FullName = "Tim Berners-Lee", Nationality = "US", ReqPhotoPath = puri("Berners-Lee.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 2, Date = new DateTime(1955, 6, 8), Description = "Дата Рождения", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 2, Date = new DateTime(1989, 6, 8), Description = "Hypertext Project", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }
            {//3
                Celebrity c = new Celebrity() { FullName = "Edgar Codd", Nationality = "US", ReqPhotoPath = puri("Codd.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 3, Date = new DateTime(1923, 8, 23), Description = "Дата Рождения", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 3, Date = new DateTime(2003, 4, 18), Description = "Smert", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }
            {//4
                Celebrity c = new Celebrity() { FullName = "Donlad Knuth", Nationality = "US", ReqPhotoPath = puri("Knuth.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 4, Date = new DateTime(1938, 1, 10), Description = "Дата Рождения", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 4, Date = new DateTime(1974, 1, 1), Description = "Turing Award", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }
            {//5
                Celebrity c = new Celebrity() { FullName = "Linus Torvalds", Nationality = "US", ReqPhotoPath = puri("Linus.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 5, Date = new DateTime(1969, 12, 7), Description = "Дата Рождения. Finland", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 5, Date = new DateTime(1991, 9, 17), Description = "Book logic structure of linguistic theory", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }
            {//6
                Celebrity c = new Celebrity() { FullName = "John Neumann", Nationality = "US", ReqPhotoPath = puri("Neumann.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 6, Date = new DateTime(1903, 12, 28), Description = "Дата Рождения. Венгрия", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 6, Date = new DateTime(1957, 2, 8), Description = "Pogib", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }
            {//7
                Celebrity c = new Celebrity() { FullName = "Edsger Dijsktra", Nationality = "NL", ReqPhotoPath = puri("Dijkstra.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 7, Date = new DateTime(1930, 5, 11), Description = "Дата Рождения", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 7, Date = new DateTime(2002, 8, 6), Description = "Pogib", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }
            {//8
                Celebrity c = new Celebrity() { FullName = "Ada Lovelace", Nationality = "UK", ReqPhotoPath = puri("Lovelace.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 8, Date = new DateTime(1852, 11, 27), Description = "Дата Рождения", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 8, Date = new DateTime(1915, 12, 10), Description = "Smert :(", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }
            {//9
                Celebrity c = new Celebrity() { FullName = "Charles Babbage", Nationality = "UK", ReqPhotoPath = puri("Babbage.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 9, Date = new DateTime(1791, 12, 26), Description = "Дата Рождения", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 9, Date = new DateTime(1871, 10, 18), Description = "Umer", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }
            {//10
                Celebrity c = new Celebrity() { FullName = "Andrew Tanenbaum", Nationality = "NL", ReqPhotoPath = puri("Tanenbaum.jpg") };
                LifeEvent l1 = new LifeEvent() { CelebrityId = 10, Date = new DateTime(1944, 3, 16), Description = "Дата Рождения", ReqPhotoPath = null };
                LifeEvent l2 = new LifeEvent() { CelebrityId = 10, Date = new DateTime(1987, 1, 1), Description = "OS MINIX", ReqPhotoPath = null };

                context.Celebrities.Add(c);
                context.LifeEvents.Add(l1);
                context.LifeEvents.Add(l2);
            }

            context.SaveChanges();
        }
    }
}