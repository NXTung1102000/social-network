using Microsoft.EntityFrameworkCore;
using Model.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Enum;

namespace Model.Seeding
{
    public class UsersSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "lhoonahan0",
                    Password = string.Empty,
                    Email = "lhoonahan0@about.com",
                    Phonenumber = "+86 300 494 5588",
                    DisplayName = "Lucia Hoonahan",
                    Gender = GenderEnum.Female,
                    Address = "Room 1137",
                    Birthday = DateTime.SpecifyKind(new DateTime(2003, 12, 9), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "nrenish1",
                    Password = string.Empty,
                    Email = "nrenish1@xing.com",
                    Phonenumber = "+62 571 701 4868",
                    DisplayName = "Nikolaus Renish",
                    Gender = GenderEnum.Male,
                    Address = "Suite 68",
                    Birthday = DateTime.SpecifyKind(new DateTime(1998, 5, 23), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "uclamo2",
                    Password = string.Empty,
                    Email = "uclamo2@google.it",
                    Phonenumber = "+225 789 424 7730",
                    DisplayName = "Ulric Clamo",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 86531",
                    Birthday = DateTime.SpecifyKind(new DateTime(1991, 8, 16), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "ghacaud3",
                    Password = string.Empty,
                    Email = "ghacaud3@walmart.com",
                    Phonenumber = "+7 123 481 5931",
                    DisplayName = "Glynda Hacaud",
                    Gender = GenderEnum.Female,
                    Address = "Room 1376",
                    Birthday = DateTime.SpecifyKind(new DateTime(1997, 7, 14), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "bwinpenny4",
                    Password = string.Empty,
                    Email = "bwinpenny4@apple.com",
                    Phonenumber = "+63 589 534 6421",
                    DisplayName = "Berke Winpenny",
                    Gender = GenderEnum.Male,
                    Address = "Suite 97",
                    Birthday = DateTime.SpecifyKind(new DateTime(1981, 4, 11), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mdacre5",
                    Password = string.Empty,
                    Email = "mdacre5@elpais.com",
                    Phonenumber = "+55 108 859 9235",
                    DisplayName = "Milt Dacre",
                    Gender = GenderEnum.Male,
                    Address = "Suite 91",
                    Birthday = DateTime.SpecifyKind(new DateTime(2009, 2, 10), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "bwinny6",
                    Password = string.Empty,
                    Email = "bwinny6@cisco.com",
                    Phonenumber = "+234 872 112 9439",
                    DisplayName = "Basia Winny",
                    Gender = GenderEnum.Female,
                    Address = "Apt 231",
                    Birthday = DateTime.SpecifyKind(new DateTime(1992, 5, 31), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "esiggery7",
                    Password = string.Empty,
                    Email = "esiggery7@fc2.com",
                    Phonenumber = "+86 825 991 0078",
                    DisplayName = "Emeline Siggery",
                    Gender = GenderEnum.Female,
                    Address = "14th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(2000, 6, 23), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "aekell8",
                    Password = string.Empty,
                    Email = "aekell8@dion.ne.jp",
                    Phonenumber = "+359 394 533 3016",
                    DisplayName = "Avrom Ekell",
                    Gender = GenderEnum.Male,
                    Address = "Suite 73",
                    Birthday = DateTime.SpecifyKind(new DateTime(2004, 8, 27), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "fberger9",
                    Password = string.Empty,
                    Email = "fberger9@wikia.com",
                    Phonenumber = "+33 558 260 3689",
                    DisplayName = "Felicity Berger",
                    Gender = GenderEnum.Female,
                    Address = "Suite 70",
                    Birthday = DateTime.SpecifyKind(new DateTime(1983, 8, 10), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "rgoodeea",
                    Password = string.Empty,
                    Email = "rgoodeea@bloomberg.com",
                    Phonenumber = "+86 954 209 1325",
                    DisplayName = "Rosalyn Goodee",
                    Gender = GenderEnum.Female,
                    Address = "Room 669",
                    Birthday = DateTime.SpecifyKind(new DateTime(1986, 6, 24), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "wfisbyb",
                    Password = string.Empty,
                    Email = "wfisbyb@paginegialle.it",
                    Phonenumber = "+57 751 674 5993",
                    DisplayName = "Wylma Fisby",
                    Gender = GenderEnum.Female,
                    Address = "4th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1996, 9, 29), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "jmasic",
                    Password = string.Empty,
                    Email = "jmasic@technorati.com",
                    Phonenumber = "+54 145 835 4156",
                    DisplayName = "Jessamyn Masi",
                    Gender = GenderEnum.Female,
                    Address = "Apt 41",
                    Birthday = DateTime.SpecifyKind(new DateTime(1980, 12, 6), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mlaveryd",
                    Password = string.Empty,
                    Email = "mlaveryd@fastcompany.com",
                    Phonenumber = "+47 200 531 0688",
                    DisplayName = "Milicent Lavery",
                    Gender = GenderEnum.Female,
                    Address = "Room 1897",
                    Birthday = DateTime.SpecifyKind(new DateTime(2008, 2, 24), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "areglare",
                    Password = string.Empty,
                    Email = "areglare@illinois.edu",
                    Phonenumber = "+62 573 904 8222",
                    DisplayName = "Atalanta Reglar",
                    Gender = GenderEnum.Female,
                    Address = "PO Box 94863",
                    Birthday = DateTime.SpecifyKind(new DateTime(1996, 6, 18), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "ppinnegarf",
                    Password = string.Empty,
                    Email = "ppinnegarf@dropbox.com",
                    Phonenumber = "+55 742 938 0535",
                    DisplayName = "Paxon Pinnegar",
                    Gender = GenderEnum.Male,
                    Address = "11th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(2006, 11, 13), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "gmarieng",
                    Password = string.Empty,
                    Email = "gmarieng@columbia.edu",
                    Phonenumber = "+86 192 818 4804",
                    DisplayName = "Gasper Marien",
                    Gender = GenderEnum.Male,
                    Address = "Room 1240",
                    Birthday = DateTime.SpecifyKind(new DateTime(2000, 2, 23), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "tferronh",
                    Password = string.Empty,
                    Email = "tferronh@tamu.edu",
                    Phonenumber = "+48 410 657 5879",
                    DisplayName = "Toiboid Ferron",
                    Gender = GenderEnum.Male,
                    Address = "Suite 73",
                    Birthday = DateTime.SpecifyKind(new DateTime(1996, 12, 1), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "lsutcliffi",
                    Password = string.Empty,
                    Email = "lsutcliffi@nbcnews.com",
                    Phonenumber = "+86 806 514 6703",
                    DisplayName = "Layton Sutcliff",
                    Gender = GenderEnum.Male,
                    Address = "Apt 1780",
                    Birthday = DateTime.SpecifyKind(new DateTime(1998, 4, 4), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "bholtomj",
                    Password = string.Empty,
                    Email = "bholtomj@miitbeian.gov.cn",
                    Phonenumber = "+48 434 166 5456",
                    DisplayName = "Brittney Holtom",
                    Gender = GenderEnum.Female,
                    Address = "Room 675",
                    Birthday = DateTime.SpecifyKind(new DateTime(2009, 2, 11), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "gruvelk",
                    Password = string.Empty,
                    Email = "gruvelk@cam.ac.uk",
                    Phonenumber = "+62 873 428 9886",
                    DisplayName = "Gabriel Ruvel",
                    Gender = GenderEnum.Female,
                    Address = "PO Box 51977",
                    Birthday = DateTime.SpecifyKind(new DateTime(2008, 11, 7), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "estagl",
                    Password = string.Empty,
                    Email = "estagl@cdbaby.com",
                    Phonenumber = "+86 824 914 9036",
                    DisplayName = "Eva Stag",
                    Gender = GenderEnum.Female,
                    Address = "8th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1999, 9, 21), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mleallm",
                    Password = string.Empty,
                    Email = "mleallm@addtoany.com",
                    Phonenumber = "+7 161 251 3077",
                    DisplayName = "Marya Leall",
                    Gender = GenderEnum.Female,
                    Address = "Apt 99",
                    Birthday = DateTime.SpecifyKind(new DateTime(1996, 3, 25), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "slowatern",
                    Password = string.Empty,
                    Email = "slowatern@clickbank.net",
                    Phonenumber = "+62 479 865 7435",
                    DisplayName = "Sherlocke Lowater",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 2439",
                    Birthday = DateTime.SpecifyKind(new DateTime(1999, 4, 13), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "cgrimsdykeo",
                    Password = string.Empty,
                    Email = "cgrimsdykeo@example.com",
                    Phonenumber = "+86 284 638 5779",
                    DisplayName = "Clair Grimsdyke",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 52305",
                    Birthday = DateTime.SpecifyKind(new DateTime(1986, 1, 28), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "ghoulistonp",
                    Password = string.Empty,
                    Email = "ghoulistonp@free.fr",
                    Phonenumber = "+381 399 927 7606",
                    DisplayName = "Geno Houliston",
                    Gender = GenderEnum.Male,
                    Address = "Apt 660",
                    Birthday = DateTime.SpecifyKind(new DateTime(2001, 3, 17), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mknellenq",
                    Password = string.Empty,
                    Email = "mknellenq@dmoz.org",
                    Phonenumber = "+81 410 501 7491",
                    DisplayName = "Mackenzie Knellen",
                    Gender = GenderEnum.Male,
                    Address = "Suite 59",
                    Birthday = DateTime.SpecifyKind(new DateTime(2006, 11, 13), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "ykortingr",
                    Password = string.Empty,
                    Email = "ykortingr@wikispaces.com",
                    Phonenumber = "+351 780 597 3423",
                    DisplayName = "Yolanda Korting",
                    Gender = GenderEnum.Female,
                    Address = "Suite 4",
                    Birthday = DateTime.SpecifyKind(new DateTime(1995, 12, 3), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "kreans",
                    Password = string.Empty,
                    Email = "kreans@wunderground.com",
                    Phonenumber = "+63 754 718 0421",
                    DisplayName = "Kearney Rean",
                    Gender = GenderEnum.Male,
                    Address = "Suite 31",
                    Birthday = DateTime.SpecifyKind(new DateTime(2002, 10, 13), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "bhindmoort",
                    Password = string.Empty,
                    Email = "bhindmoort@intel.com",
                    Phonenumber = "+33 486 310 5537",
                    DisplayName = "Blakelee Hindmoor",
                    Gender = GenderEnum.Female,
                    Address = "Suite 10",
                    Birthday = DateTime.SpecifyKind(new DateTime(1989, 7, 1), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "cfassu",
                    Password = string.Empty,
                    Email = "cfassu@smugmug.com",
                    Phonenumber = "+62 444 390 4281",
                    DisplayName = "Caitrin Fass",
                    Gender = GenderEnum.Female,
                    Address = "Suite 10",
                    Birthday = DateTime.SpecifyKind(new DateTime(2001, 7, 22), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "tellowayv",
                    Password = string.Empty,
                    Email = "tellowayv@umn.edu",
                    Phonenumber = "+86 751 400 2866",
                    DisplayName = "Tabor Elloway",
                    Gender = GenderEnum.Male,
                    Address = "Suite 15",
                    Birthday = DateTime.SpecifyKind(new DateTime(1995, 11, 30), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "tcartmelw",
                    Password = string.Empty,
                    Email = "tcartmelw@wix.com",
                    Phonenumber = "+1 716 592 5014",
                    DisplayName = "Theodoric Cartmel",
                    Gender = GenderEnum.Male,
                    Address = "Room 211",
                    Birthday = DateTime.SpecifyKind(new DateTime(1996, 5, 9), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "loldroydex",
                    Password = string.Empty,
                    Email = "loldroydex@1688.com",
                    Phonenumber = "+92 218 551 3914",
                    DisplayName = "Lydon Oldroyde",
                    Gender = GenderEnum.Male,
                    Address = "Suite 30",
                    Birthday = DateTime.SpecifyKind(new DateTime(2000, 5, 14), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "jmansiony",
                    Password = string.Empty,
                    Email = "jmansiony@stanford.edu",
                    Phonenumber = "+62 140 338 5498",
                    DisplayName = "Jacenta Mansion",
                    Gender = GenderEnum.Female,
                    Address = "Room 330",
                    Birthday = DateTime.SpecifyKind(new DateTime(1992, 1, 26), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "lblissittz",
                    Password = string.Empty,
                    Email = "lblissittz@cnn.com",
                    Phonenumber = "+86 847 599 0102",
                    DisplayName = "Lennard Blissitt",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 6255",
                    Birthday = DateTime.SpecifyKind(new DateTime(2001, 4, 14), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "rrookes10",
                    Password = string.Empty,
                    Email = "rrookes10@1und1.de",
                    Phonenumber = "+86 588 961 3952",
                    DisplayName = "Randell Rookes",
                    Gender = GenderEnum.Male,
                    Address = "Room 354",
                    Birthday = DateTime.SpecifyKind(new DateTime(1984, 1, 24), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mhadrill11",
                    Password = string.Empty,
                    Email = "mhadrill11@csmonitor.com",
                    Phonenumber = "+55 150 897 1287",
                    DisplayName = "Mozes Hadrill",
                    Gender = GenderEnum.Male,
                    Address = "Room 1290",
                    Birthday = DateTime.SpecifyKind(new DateTime(1999, 4, 7), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "bhooban12",
                    Password = string.Empty,
                    Email = "bhooban12@noaa.gov",
                    Phonenumber = "+52 339 266 6510",
                    DisplayName = "Byrom Hooban",
                    Gender = GenderEnum.Male,
                    Address = "Apt 1883",
                    Birthday = DateTime.SpecifyKind(new DateTime(2005, 3, 8), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "csteeples13",
                    Password = string.Empty,
                    Email = "csteeples13@reuters.com",
                    Phonenumber = "+86 963 339 5732",
                    DisplayName = "Che Steeples",
                    Gender = GenderEnum.Female,
                    Address = "19th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1987, 6, 19), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "ohanscombe14",
                    Password = string.Empty,
                    Email = "ohanscombe14@scientificamerican.com",
                    Phonenumber = "+46 606 276 4004",
                    DisplayName = "Odette Hanscombe",
                    Gender = GenderEnum.Female,
                    Address = "Apt 624",
                    Birthday = DateTime.SpecifyKind(new DateTime(1995, 11, 11), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mmckew15",
                    Password = string.Empty,
                    Email = "mmckew15@cpanel.net",
                    Phonenumber = "+62 243 987 9010",
                    DisplayName = "Maris McKew",
                    Gender = GenderEnum.Female,
                    Address = "9th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(2009, 12, 22), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "cdanick16",
                    Password = string.Empty,
                    Email = "cdanick16@bravesites.com",
                    Phonenumber = "+7 192 313 4831",
                    DisplayName = "Cassandra Danick",
                    Gender = GenderEnum.Female,
                    Address = "Room 1551",
                    Birthday = DateTime.SpecifyKind(new DateTime(1996, 3, 24), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "sharly17",
                    Password = string.Empty,
                    Email = "sharly17@foxnews.com",
                    Phonenumber = "+1 921 953 8511",
                    DisplayName = "Sybille Harly",
                    Gender = GenderEnum.Female,
                    Address = "Suite 47",
                    Birthday = DateTime.SpecifyKind(new DateTime(2009, 7, 16), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "gstile18",
                    Password = string.Empty,
                    Email = "gstile18@studiopress.com",
                    Phonenumber = "+1 323 215 8229",
                    DisplayName = "Gertie Stile",
                    Gender = GenderEnum.Female,
                    Address = "Suite 50",
                    Birthday = DateTime.SpecifyKind(new DateTime(1986, 7, 10), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "twhyborne19",
                    Password = string.Empty,
                    Email = "twhyborne19@cnn.com",
                    Phonenumber = "+1 303 573 3210",
                    DisplayName = "Tomkin Whyborne",
                    Gender = GenderEnum.Male,
                    Address = "2nd Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1995, 8, 8), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "dhodgets1a",
                    Password = string.Empty,
                    Email = "dhodgets1a@indiegogo.com",
                    Phonenumber = "+62 912 164 9763",
                    DisplayName = "Darrel Hodgets",
                    Gender = GenderEnum.Male,
                    Address = "Suite 8",
                    Birthday = DateTime.SpecifyKind(new DateTime(1989, 10, 6), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "hsmooth1b",
                    Password = string.Empty,
                    Email = "hsmooth1b@gizmodo.com",
                    Phonenumber = "+52 243 441 6891",
                    DisplayName = "Herbert Smooth",
                    Gender = GenderEnum.Male,
                    Address = "Suite 95",
                    Birthday = DateTime.SpecifyKind(new DateTime(1995, 11, 30), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mbisatt1c",
                    Password = string.Empty,
                    Email = "mbisatt1c@bloomberg.com",
                    Phonenumber = "+7 961 460 2271",
                    DisplayName = "Marlena Bisatt",
                    Gender = GenderEnum.Female,
                    Address = "3rd Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(2000, 10, 13), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mdi1d",
                    Password = string.Empty,
                    Email = "mdi1d@gov.uk",
                    Phonenumber = "+63 298 301 0165",
                    DisplayName = "Miran Di Giacomo",
                    Gender = GenderEnum.Female,
                    Address = "Suite 38",
                    Birthday = DateTime.SpecifyKind(new DateTime(2003, 5, 8), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "squeyos1e",
                    Password = string.Empty,
                    Email = "squeyos1e@berkeley.edu",
                    Phonenumber = "+257 107 131 9355",
                    DisplayName = "Sindee Queyos",
                    Gender = GenderEnum.Female,
                    Address = "Room 1783",
                    Birthday = DateTime.SpecifyKind(new DateTime(1982, 4, 15), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "abrittain1f",
                    Password = string.Empty,
                    Email = "abrittain1f@sitemeter.com",
                    Phonenumber = "+20 583 926 7348",
                    DisplayName = "Arri Brittain",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 90561",
                    Birthday = DateTime.SpecifyKind(new DateTime(1998, 1, 10), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "fhughf1g",
                    Password = string.Empty,
                    Email = "fhughf1g@blogger.com",
                    Phonenumber = "+54 688 811 0111",
                    DisplayName = "Flint Hughf",
                    Gender = GenderEnum.Male,
                    Address = "Apt 1825",
                    Birthday = DateTime.SpecifyKind(new DateTime(2003, 7, 26), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "sprovest1h",
                    Password = string.Empty,
                    Email = "sprovest1h@google.de",
                    Phonenumber = "+62 436 581 8351",
                    DisplayName = "Shurlock Provest",
                    Gender = GenderEnum.Male,
                    Address = "17th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1990, 2, 21), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "jfountaine1i",
                    Password = string.Empty,
                    Email = "jfountaine1i@nifty.com",
                    Phonenumber = "+86 140 511 4550",
                    DisplayName = "Jennifer Fountaine",
                    Gender = GenderEnum.Female,
                    Address = "Room 1257",
                    Birthday = DateTime.SpecifyKind(new DateTime(1982, 4, 27), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "gluckes1j",
                    Password = string.Empty,
                    Email = "gluckes1j@senate.gov",
                    Phonenumber = "+62 822 689 1861",
                    DisplayName = "Gerek Luckes",
                    Gender = GenderEnum.Male,
                    Address = "Apt 927",
                    Birthday = DateTime.SpecifyKind(new DateTime(1991, 1, 21), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "cevershed1k",
                    Password = string.Empty,
                    Email = "cevershed1k@cargocollective.com",
                    Phonenumber = "+7 881 914 0088",
                    DisplayName = "Cami Evershed",
                    Gender = GenderEnum.Female,
                    Address = "PO Box 43205",
                    Birthday = DateTime.SpecifyKind(new DateTime(1985, 12, 29), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "twaddingham1l",
                    Password = string.Empty,
                    Email = "twaddingham1l@state.tx.us",
                    Phonenumber = "+48 460 879 7856",
                    DisplayName = "Tuckie Waddingham",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 1316",
                    Birthday = DateTime.SpecifyKind(new DateTime(2010, 5, 7), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "esaywell1m",
                    Password = string.Empty,
                    Email = "esaywell1m@plala.or.jp",
                    Phonenumber = "+86 464 845 6785",
                    DisplayName = "Esteban Saywell",
                    Gender = GenderEnum.Male,
                    Address = "14th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1993, 9, 11), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "tbeney1n",
                    Password = string.Empty,
                    Email = "tbeney1n@slideshare.net",
                    Phonenumber = "+93 805 555 6783",
                    DisplayName = "Tanya Beney",
                    Gender = GenderEnum.Female,
                    Address = "Room 254",
                    Birthday = DateTime.SpecifyKind(new DateTime(1990, 11, 20), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "kcrux1o",
                    Password = string.Empty,
                    Email = "kcrux1o@nyu.edu",
                    Phonenumber = "+55 670 213 2116",
                    DisplayName = "Kelly Crux",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 65263",
                    Birthday = DateTime.SpecifyKind(new DateTime(1998, 3, 1), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mgriffith1p",
                    Password = string.Empty,
                    Email = "mgriffith1p@auda.org.au",
                    Phonenumber = "+86 538 268 2153",
                    DisplayName = "Mortimer Griffith",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 69627",
                    Birthday = DateTime.SpecifyKind(new DateTime(1985, 7, 8), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "ipennazzi1q",
                    Password = string.Empty,
                    Email = "ipennazzi1q@acquirethisname.com",
                    Phonenumber = "+84 255 358 5970",
                    DisplayName = "Iago Pennazzi",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 27189",
                    Birthday = DateTime.SpecifyKind(new DateTime(1997, 6, 18), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mcaren1r",
                    Password = string.Empty,
                    Email = "mcaren1r@boston.com",
                    Phonenumber = "+1 775 488 0749",
                    DisplayName = "Marci Caren",
                    Gender = GenderEnum.Female,
                    Address = "Suite 26",
                    Birthday = DateTime.SpecifyKind(new DateTime(1980, 2, 16), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "zanglim1s",
                    Password = string.Empty,
                    Email = "zanglim1s@w3.org",
                    Phonenumber = "+81 819 881 8979",
                    DisplayName = "Zedekiah Anglim",
                    Gender = GenderEnum.Male,
                    Address = "19th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1993, 11, 14), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mivanyushin1t",
                    Password = string.Empty,
                    Email = "mivanyushin1t@sbwire.com",
                    Phonenumber = "+86 931 881 5172",
                    DisplayName = "Merell Ivanyushin",
                    Gender = GenderEnum.Male,
                    Address = "Suite 7",
                    Birthday = DateTime.SpecifyKind(new DateTime(1999, 7, 12), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "rfairlaw1u",
                    Password = string.Empty,
                    Email = "rfairlaw1u@statcounter.com",
                    Phonenumber = "+593 213 988 7999",
                    DisplayName = "Ragnar Fairlaw",
                    Gender = GenderEnum.Male,
                    Address = "Room 930",
                    Birthday = DateTime.SpecifyKind(new DateTime(1990, 4, 22), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "cweerdenburg1v",
                    Password = string.Empty,
                    Email = "cweerdenburg1v@statcounter.com",
                    Phonenumber = "+33 186 970 4221",
                    DisplayName = "Corabel Weerdenburg",
                    Gender = GenderEnum.Female,
                    Address = "5th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1991, 11, 23), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "amudd1w",
                    Password = string.Empty,
                    Email = "amudd1w@paypal.com",
                    Phonenumber = "+86 986 432 3434",
                    DisplayName = "Ardene Mudd",
                    Gender = GenderEnum.Female,
                    Address = "Room 233",
                    Birthday = DateTime.SpecifyKind(new DateTime(1983, 1, 3), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "ohindhaugh1x",
                    Password = string.Empty,
                    Email = "ohindhaugh1x@zimbio.com",
                    Phonenumber = "+86 779 538 4975",
                    DisplayName = "Ogdon Hindhaugh",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 23862",
                    Birthday = DateTime.SpecifyKind(new DateTime(1995, 6, 21), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "pduckfield1y",
                    Password = string.Empty,
                    Email = "pduckfield1y@microsoft.com",
                    Phonenumber = "+33 777 268 1515",
                    DisplayName = "Paulie Duckfield",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 86697",
                    Birthday = DateTime.SpecifyKind(new DateTime(1999, 12, 5), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "eradbond1z",
                    Password = string.Empty,
                    Email = "eradbond1z@mit.edu",
                    Phonenumber = "+51 628 717 1060",
                    DisplayName = "Emili Radbond",
                    Gender = GenderEnum.Female,
                    Address = "Room 1388",
                    Birthday = DateTime.SpecifyKind(new DateTime(1988, 5, 11), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "kcarnow20",
                    Password = string.Empty,
                    Email = "kcarnow20@ox.ac.uk",
                    Phonenumber = "+33 107 228 2828",
                    DisplayName = "Kathlin Carnow",
                    Gender = GenderEnum.Female,
                    Address = "10th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(2005, 8, 17), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "vdenzilow21",
                    Password = string.Empty,
                    Email = "vdenzilow21@elegantthemes.com",
                    Phonenumber = "+86 894 860 3333",
                    DisplayName = "Vincenty Denzilow",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 27159",
                    Birthday = DateTime.SpecifyKind(new DateTime(1986, 12, 27), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "ncrocetto22",
                    Password = string.Empty,
                    Email = "ncrocetto22@nydailynews.com",
                    Phonenumber = "+55 374 459 4021",
                    DisplayName = "Nickolai Crocetto",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 36056",
                    Birthday = DateTime.SpecifyKind(new DateTime(1986, 5, 10), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "tgisburn23",
                    Password = string.Empty,
                    Email = "tgisburn23@wordpress.org",
                    Phonenumber = "+86 589 185 4668",
                    DisplayName = "Trenton Gisburn",
                    Gender = GenderEnum.Male,
                    Address = "16th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(2000, 9, 27), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "rdavidi24",
                    Password = string.Empty,
                    Email = "rdavidi24@unblog.fr",
                    Phonenumber = "+63 960 493 0562",
                    DisplayName = "Rhodia Davidi",
                    Gender = GenderEnum.Female,
                    Address = "Apt 1846",
                    Birthday = DateTime.SpecifyKind(new DateTime(2005, 11, 16), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "pcummins25",
                    Password = string.Empty,
                    Email = "pcummins25@craigslist.org",
                    Phonenumber = "+63 651 830 9069",
                    DisplayName = "Phineas Cummins",
                    Gender = GenderEnum.Male,
                    Address = "Apt 1586",
                    Birthday = DateTime.SpecifyKind(new DateTime(1999, 10, 25), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "tludee26",
                    Password = string.Empty,
                    Email = "tludee26@merriam-webster.com",
                    Phonenumber = "+49 744 381 3187",
                    DisplayName = "Thedrick Ludee",
                    Gender = GenderEnum.Male,
                    Address = "Suite 80",
                    Birthday = DateTime.SpecifyKind(new DateTime(2009, 3, 6), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "sferras27",
                    Password = string.Empty,
                    Email = "sferras27@miitbeian.gov.cn",
                    Phonenumber = "+63 565 382 1877",
                    DisplayName = "Susan Ferras",
                    Gender = GenderEnum.Female,
                    Address = "Room 629",
                    Birthday = DateTime.SpecifyKind(new DateTime(2007, 9, 15), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "dmarjot28",
                    Password = string.Empty,
                    Email = "dmarjot28@naver.com",
                    Phonenumber = "+56 311 922 2790",
                    DisplayName = "Dianna Marjot",
                    Gender = GenderEnum.Female,
                    Address = "PO Box 38947",
                    Birthday = DateTime.SpecifyKind(new DateTime(1981, 12, 16), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "tsans29",
                    Password = string.Empty,
                    Email = "tsans29@delicious.com",
                    Phonenumber = "+387 134 469 3559",
                    DisplayName = "Tarrance Sans",
                    Gender = GenderEnum.Male,
                    Address = "17th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1997, 11, 19), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "rharbisher2a",
                    Password = string.Empty,
                    Email = "rharbisher2a@mapquest.com",
                    Phonenumber = "+27 472 646 0728",
                    DisplayName = "Rebekah Harbisher",
                    Gender = GenderEnum.Female,
                    Address = "Apt 262",
                    Birthday = DateTime.SpecifyKind(new DateTime(1996, 11, 18), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "tmckennan2b",
                    Password = string.Empty,
                    Email = "tmckennan2b@wufoo.com",
                    Phonenumber = "+63 119 604 8230",
                    DisplayName = "Thayne McKennan",
                    Gender = GenderEnum.Male,
                    Address = "Suite 19",
                    Birthday = DateTime.SpecifyKind(new DateTime(1995, 4, 14), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mmelson2c",
                    Password = string.Empty,
                    Email = "mmelson2c@free.fr",
                    Phonenumber = "+221 146 447 5591",
                    DisplayName = "Marja Melson",
                    Gender = GenderEnum.Female,
                    Address = "Suite 68",
                    Birthday = DateTime.SpecifyKind(new DateTime(2004, 4, 3), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "sbuxam2d",
                    Password = string.Empty,
                    Email = "sbuxam2d@ifeng.com",
                    Phonenumber = "+51 739 742 4507",
                    DisplayName = "Sorcha Buxam",
                    Gender = GenderEnum.Female,
                    Address = "Room 1478",
                    Birthday = DateTime.SpecifyKind(new DateTime(2007, 8, 6), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "bespinho2e",
                    Password = string.Empty,
                    Email = "bespinho2e@zimbio.com",
                    Phonenumber = "+84 301 980 4189",
                    DisplayName = "Brendin Espinho",
                    Gender = GenderEnum.Male,
                    Address = "Room 1048",
                    Birthday = DateTime.SpecifyKind(new DateTime(2007, 7, 15), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "blohan2f",
                    Password = string.Empty,
                    Email = "blohan2f@oracle.com",
                    Phonenumber = "+86 484 290 1614",
                    DisplayName = "Burton Lohan",
                    Gender = GenderEnum.Male,
                    Address = "Room 280",
                    Birthday = DateTime.SpecifyKind(new DateTime(1983, 10, 13), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "hduchenne2g",
                    Password = string.Empty,
                    Email = "hduchenne2g@mit.edu",
                    Phonenumber = "+86 883 971 0140",
                    DisplayName = "Hannis Duchenne",
                    Gender = GenderEnum.Female,
                    Address = "Suite 90",
                    Birthday = DateTime.SpecifyKind(new DateTime(1994, 10, 19), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "edurning2h",
                    Password = string.Empty,
                    Email = "edurning2h@cbslocal.com",
                    Phonenumber = "+62 120 600 4007",
                    DisplayName = "Eben Durning",
                    Gender = GenderEnum.Male,
                    Address = "12th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(2003, 8, 22), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "dbrisse2i",
                    Password = string.Empty,
                    Email = "dbrisse2i@mail.ru",
                    Phonenumber = "+7 292 805 6250",
                    DisplayName = "Dalia Brisse",
                    Gender = GenderEnum.Female,
                    Address = "Suite 79",
                    Birthday = DateTime.SpecifyKind(new DateTime(1989, 10, 17), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "mhamill2j",
                    Password = string.Empty,
                    Email = "mhamill2j@xing.com",
                    Phonenumber = "+33 704 414 5928",
                    DisplayName = "Martino Hamill",
                    Gender = GenderEnum.Male,
                    Address = "Room 379",
                    Birthday = DateTime.SpecifyKind(new DateTime(2007, 4, 27), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "dlagadu2k",
                    Password = string.Empty,
                    Email = "dlagadu2k@independent.co.uk",
                    Phonenumber = "+1 929 272 5138",
                    DisplayName = "Dee Lagadu",
                    Gender = GenderEnum.Female,
                    Address = "14th Floor",
                    Birthday = DateTime.SpecifyKind(new DateTime(1987, 2, 16), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "possulton2l",
                    Password = string.Empty,
                    Email = "possulton2l@ow.ly",
                    Phonenumber = "+502 562 498 8408",
                    DisplayName = "Patrizio Ossulton",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 66928",
                    Birthday = DateTime.SpecifyKind(new DateTime(1989, 2, 13), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "crhead2m",
                    Password = string.Empty,
                    Email = "crhead2m@nytimes.com",
                    Phonenumber = "+62 668 105 8368",
                    DisplayName = "Caroline Rhead",
                    Gender = GenderEnum.Female,
                    Address = "Apt 1196",
                    Birthday = DateTime.SpecifyKind(new DateTime(1984, 7, 15), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "jgyver2n",
                    Password = string.Empty,
                    Email = "jgyver2n@skyrock.com",
                    Phonenumber = "+66 966 304 1461",
                    DisplayName = "Jeanne Gyver",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 43206",
                    Birthday = DateTime.SpecifyKind(new DateTime(2010, 10, 29), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "dassiratti2o",
                    Password = string.Empty,
                    Email = "dassiratti2o@boston.com",
                    Phonenumber = "+353 619 790 4818",
                    DisplayName = "Desiri Assiratti",
                    Gender = GenderEnum.Female,
                    Address = "Apt 81",
                    Birthday = DateTime.SpecifyKind(new DateTime(1981, 11, 21), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "ncrosfield2p",
                    Password = string.Empty,
                    Email = "ncrosfield2p@mayoclinic.com",
                    Phonenumber = "+1 214 266 7530",
                    DisplayName = "Noland Crosfield",
                    Gender = GenderEnum.Male,
                    Address = "PO Box 26645",
                    Birthday = DateTime.SpecifyKind(new DateTime(1982, 5, 30), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "tbrandino2q",
                    Password = string.Empty,
                    Email = "tbrandino2q@nps.gov",
                    Phonenumber = "+48 780 793 5631",
                    DisplayName = "Thorny Brandino",
                    Gender = GenderEnum.Male,
                    Address = "Room 206",
                    Birthday = DateTime.SpecifyKind(new DateTime(1995, 8, 16), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    UserName = "emingaye2r",
                    Password = string.Empty,
                    Email = "emingaye2r@google.es",
                    Phonenumber = "+1 216 114 7742",
                    DisplayName = "Eugen Mingaye",
                    Gender = GenderEnum.Male,
                    Address = "Apt 1593",
                    Birthday = DateTime.SpecifyKind(new DateTime(1989, 2, 26), DateTimeKind.Utc),
                    RefreshToken = string.Empty
                }
            );
        }
    }
}
