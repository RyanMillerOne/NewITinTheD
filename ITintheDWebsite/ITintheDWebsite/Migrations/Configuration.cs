namespace ITintheDWebsite.Migrations
{
    using ITintheDWebsite.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ITintheDWebsite.Models.DBEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /*protected override void Seed(ITintheDWebsite.Models.MentorDBContext context)
        {
            context.Mentors.AddOrUpdate(m => m.Name,
            new Mentor
            {
                Name = "Dashaun Houston",
                Info = "adsajkfhg ksjadfh gkajshf gkajsf gdakjshf gakjshdf gskajhdf gksjdgf askjhdf gsakjdh gaskd"
            },
            new Mentor
            {
                Name = "Brian Friesen",
                Info = "dskafjhgask fhsadjfgskadhg fkajsdhg fkjhd fgskajhg fkjsah fgaskjfhd gaskjhfg askdjfhgsd akjfh gsakdjfhg "
            },
            new Mentor
            {
                Name = "Sonya Walker",
                Info = "slkdafh kjsahfdgskadjfh gkadjh gfakdjhf gaskjdfhg "
            }
            );
        }*/

        protected override void Seed(ITintheDWebsite.Models.DBEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Mentors.AddOrUpdate(m => m.Name,
            new Mentor
            {
                Name = "Dashaun Houston",
                Info = "Years Experience: <br /> Project Manager Mentor <br /> Comment"
            },
            new Mentor
            {
                Name = "Brian Friesen",
                Info = "Years Experience: <br /> Technical Mentor <br /> Comment"
            },
            new Mentor
            {
                Name = "Sonya Walker",
                Info = "Years Experience: <br /> Business Analyst Mentor<br /> Comment"
            });

            context.Apps.AddOrUpdate(a => a.Email,
                new Application
                {
                    Email = "someone@yahoo.com",
                    FirstName = "Brandon",
                    LastName = "Smith",
                    HowYouHeard = "Internet",
                    Role = "Developer",
                    Question1 = "dskjafbcsjdcud",
                    Question2 = "kasjybfcjsybjfasyfbgccdfybgcjsaygmyfbcgmjfybgcsbdfygamjsfgbjsyf",
                    Question3 = "asdfcastdjvfatbjusxntdusncfsa?"
                },
                new Application
                {
                    Email = "example@gmail.com",
                    FirstName = "Steve",
                    LastName = "Stevenson",
                    HowYouHeard = "Friend",
                    Role = "Project Manager",
                    Question1 = "sadkfjnaksjdfnka",
                    Question2 = "sakdugfybtfcjsybfcjsybdmysfbgcmsydgfcjydcmfbyjsadfgcajsdyfbcas",
                    Question3 = "csafybgdjfgmjsfbgcmjfybgcdjfybgmjfybgm"
                },
                new Application
                {
                    Email = "asd@asd.com",
                    FirstName = "George",
                    LastName = "Georgey",
                    HowYouHeard = "Other",
                    Role = "Business Analyst",
                    Question1 = "jkhcxgvbdjsbgjbdsfjfybvds",
                    Question2 = "slfdugynkidnusvykinduykgvsndufykgsindf",
                    Question3 = "gvsdiufnysvdkvnygdsfinuykdsvnygfnus"
                }
                );


        }
    }
}
