using LoginProject.Models;

namespace LoginProject
{
    public class SeedLoginDb
    {
        public void Seed()
        {
            using (LoginContext context = new LoginContext())
            {
                context.Database.EnsureCreated();
                if (context.roles.Count() == 0)
                {
                    context.roles.AddRange(new Role[]
                {
                        new Role(){RoleName = RoleName.Admin},
                        new Role(){RoleName = RoleName.Guest},
                        new Role(){RoleName = RoleName.VIP},
                        new Role(){RoleName = RoleName.Regular},
                });
                    context.SaveChanges();
                }

                if (context.users.Count() == 0)
                {
                    Role _role = context.roles.FirstOrDefault(r => r.RoleName == RoleName.Admin);
                    context.users.Add(new User() { Username = "Naumche", Password = "Joshevski123#", Role = _role });
                    context.SaveChanges();
                }

            }
        }
    }
}
