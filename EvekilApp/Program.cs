using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EvekilApp.Data;
using EvekilApp.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EvekilApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost webHost = CreateWebHostBuilder(args).Build();

            using (IServiceScope scopedService = webHost.Services.CreateScope())
            {
                using (EvekilEntity dbContext = scopedService.ServiceProvider.GetRequiredService<EvekilEntity>())
                {
                    if (!dbContext.Advocates.Any())
                    {
                        #region Advocates
                        Advocate NihadAliyev = new Advocate()
                        {
                            Name = "Nihad",
                            Surname = "Əliyev",
                            Email = "nihad@hgn.az",
                            Phone = 0502503575
                        };
                        #endregion
                        dbContext.Advocates.Add(NihadAliyev);
                        dbContext.SaveChanges();
                    }
                    if (!dbContext.Subcategories.Any() && !dbContext.Categories.Any())
                    {

                        #region Categories
                        Category category = new Category()
                        {
                            PhotoPath = "hr1.jpg",
                            Visibilty = true
                        };
                        Category category2 = new Category()
                        {
                            PhotoPath = "hr1.jpg",
                            Visibilty = true
                        };
                        Category category3 = new Category()
                        {
                            PhotoPath = "hr1.jpg",
                            Visibilty = true
                        };
                        Category category4 = new Category()
                        {
                            PhotoPath = "hr1.jpg",
                            Visibilty = true
                        };
                        dbContext.Categories.AddRange(category,category2,category3,category4);

                        CategoryLanguage IR = new CategoryLanguage()
                        {
                            Name = "İnsan Resursları",
                            Description = @"Bu bölmədə kadrlar şöbəsinin faəliyyətinə aid müxtəlif sənəd nümunələri, o cümlədən əmr formaları, əmək müqavilələri, əmək müqavilələrinə əlavələr, vəzifə təlimatları, aktlar, izahat formaları, ərizələr, əmr kitabları və s. yerləşdirilmişdir.
                                           Diqqətinizə təqdim edilən bu sənəd nümunələri Azərbaycan Respublikasında fəaliyyət göstərən müxtəlif təşkilatlar tərəfindən istifadə edilməkdədir.",
                            CategoryId = 1,
                            LanguageId = 2
                        };
                        CategoryLanguage MS = new CategoryLanguage()
                        {
                            Name = "Məhkəmə Sənədləri",
                            Description = @"Əsasən mülki və iqtisadi mübahisələr üzrə məhkəməyə qədər və məhkəmə araşdırması dövründə tərtib edilən sənəd nümunələri bu bölmədə sizin diqqətinizə təqdim edilir.
                            Sənəd nümunələri arasında təmənnasız təqdim edilən bəzi iddia ərizələri formaları ilə yanaşı, müxtəlif məzmunlu və formalı vəsatətlər, apellyasiya şikayətləri, kassasiya şikayətləri formaları və s. mövcuddur. Sənəd nümunələri Azərbaycan Respublikası Vəkillər Kollegiyasının üzvləri tərəfindən tərtib edilmişdir. Sənəd nümunələrindən real məhkəmə işlərində istifadə edilmişdir.",
                            CategoryId = 2,
                            LanguageId = 2


                        };
                        CategoryLanguage M = new CategoryLanguage()
                        {
                            Name = "Müqavilələr",
                            Description = @"Azərbaycan Respublikasının qanunvericiliyinə uyğun tərtib edilən müxtəlif müqavilə növləri. Təqdim edilən bütün müqavilə növləri təcrübədə istifadə edilmişdir.
                                           Müqavilələr arasında tez-tez istifadə edilən alğı-satqı, bağışlama, podrat, xidmət müqavilələri ilə yanaşı Azərbaycan işgüzar adətlərində yeni-yeni rast gəlinən autsorsinq, birgə əməliyyat sazişləri nümunələri də daxil edilmişdir.",
                            CategoryId = 3,
                            LanguageId = 2
                        };
                        CategoryLanguage SS = new CategoryLanguage()
                        {
                            Name = "Sair Sənədlər",
                            Description = @"Yuxarıdakı təsnifata yer almamış sənəd nümunələrini hazırki bölmədə yerləşdirərək diqqətinizə çatdırırıq. Bu bölmədə hüquqi şəxsin təsis sənədləri nümunələri, informasiya sorğuları, şikayət ərizələri, prtokol formaları, etibarnamələr, müraciət ərizələri və s. sənəd nümunələri yerləşdirilmişdir.
                                           We understand business. That's why we begin every project with a workshop — crafting a one-of-a-kind, unique strategy that is designed to help you win.",
                            CategoryId = 4,
                            LanguageId = 2
                        };
                        #endregion

                        dbContext.CategoryLanguages.AddRange(IR, M, MS, SS);
                        dbContext.SaveChanges();

                        #region Subcategories

                        #region InsanResurslariSubcategoriyasi
                        Subcategory subcategory = new Subcategory()
                        {
                            CategoryId = 1
                        };
                        dbContext.Subcategories.Add(subcategory);

                        SubcategoryLanguage EM = new SubcategoryLanguage()
                        {
                            Name = "Əmək Müqaviləsi",
                            SubcategoryId = 1,
                            LanguageId = 2
                        };
                        SubcategoryLanguage EF = new SubcategoryLanguage()
                        {
                            Name = "Əmr Formaları",
                            SubcategoryId = 1,
                            LanguageId = 2
                        };
                        SubcategoryLanguage VT = new SubcategoryLanguage()
                        {
                            Name = "Vəzifə Təlimatları",
                            SubcategoryId = 1,
                            LanguageId = 2
                        };
                        SubcategoryLanguage E = new SubcategoryLanguage()
                        {
                            Name = "Ərizələr",
                            SubcategoryId = 1,
                            LanguageId = 2
                        };
                        SubcategoryLanguage EK = new SubcategoryLanguage()
                        {
                            Name = "Əmr Kitabları",
                            SubcategoryId = 1,
                            LanguageId = 2
                        };
                        SubcategoryLanguage EV = new SubcategoryLanguage()
                        {
                            Name = "Ezamiyyə Vərəqələri",
                            SubcategoryId = 1,
                            LanguageId = 2
                        };
                        SubcategoryLanguage A = new SubcategoryLanguage()
                        {
                            Name = "Aktlar",
                            SubcategoryId = 1,
                            LanguageId = 2
                        };

                        #endregion
                        #region MehkemeSenedleriSubcategoriyasi
                        Subcategory subcategory2 = new Subcategory()
                        {
                            CategoryId = 2
                        };
                        dbContext.Subcategories.Add(subcategory2);
                        SubcategoryLanguage IE = new SubcategoryLanguage()
                        {
                            Name = "İddia Ərizələri",
                            SubcategoryId = 2,
                            LanguageId = 2
                        };
                        SubcategoryLanguage AS = new SubcategoryLanguage()
                        {
                            Name = "Apelyasiya Şikayətləri",
                            SubcategoryId = 2,
                            LanguageId = 2
                        };
                        SubcategoryLanguage KS = new SubcategoryLanguage()
                        {
                            Name = "Kassasiya Şikayətləri",
                            SubcategoryId = 2,
                            LanguageId = 2
                        };
                        SubcategoryLanguage V = new SubcategoryLanguage()
                        {
                            Name = "Vəsatətlər",
                            SubcategoryId = 2,
                            LanguageId = 2
                        };
                        SubcategoryLanguage BS = new SubcategoryLanguage()
                        {
                            Name = "Barışıq Sazişləri",
                            SubcategoryId = 2,
                            LanguageId = 2
                        };
                        SubcategoryLanguage QIE = new SubcategoryLanguage()
                        {
                            Name = "Qarşılıqlı İddia Ərizələri",
                            SubcategoryId = 2,
                            LanguageId = 2
                        };
                        SubcategoryLanguage ET = new SubcategoryLanguage()
                        {
                            Name = "Etirazlar",
                            SubcategoryId = 2,
                            LanguageId = 2
                        };
                        #endregion

                        #region MuqavilelerSubcategoriyasi
                        Subcategory subcategory3 = new Subcategory()
                        {
                            CategoryId = 3
                        };
                        dbContext.Subcategories.Add(subcategory3);
                        SubcategoryLanguage ASM = new SubcategoryLanguage()
                        {
                            Name = "Alğı-satqı Müqavilələri",
                            SubcategoryId = 3,
                            LanguageId = 2
                        };
                        SubcategoryLanguage PM = new SubcategoryLanguage()
                        {
                            Name = "Podrat Müqavilələri",
                            SubcategoryId = 3,
                            LanguageId = 2
                        };
                        SubcategoryLanguage XM = new SubcategoryLanguage()
                        {
                            Name = "Xidmət Müqavilələri",
                            SubcategoryId = 3,
                            LanguageId = 2
                        };
                        SubcategoryLanguage BM = new SubcategoryLanguage()
                        {
                            Name = "Borc Müqavilələri",
                            SubcategoryId = 3,
                            LanguageId = 2
                        };
                        SubcategoryLanguage DM = new SubcategoryLanguage()
                        {
                            Name = "Daşınma Müqavilələri",
                            SubcategoryId = 3,
                            LanguageId = 2
                        };
                        SubcategoryLanguage ME = new SubcategoryLanguage()
                        {
                            Name = "Müqavilələrə Əlavələr",
                            SubcategoryId = 3,
                            LanguageId = 2
                        };
                        SubcategoryLanguage IM = new SubcategoryLanguage()
                        {
                            Name = "İcarə Müqavilələri" +
                            "",
                            SubcategoryId = 3,
                            LanguageId = 2
                        };
                        #endregion
                        #region SairSenedlerSubcategoriyasi
                        Subcategory subcategory4 = new Subcategory()
                        {
                            CategoryId = 4
                        };
                        dbContext.Subcategories.Add(subcategory4);
                        SubcategoryLanguage HSUY = new SubcategoryLanguage()
                        {
                            Name = "Hüquqi Şəxsin Ümumi Yığıncağının Qərarı",
                            SubcategoryId = 1,
                            LanguageId = 2
                        };
                        SubcategoryLanguage EUMEF = new SubcategoryLanguage()
                        {
                            Name = "Əfv üçün Müraciət Ərizə Forması",
                            SubcategoryId = 4,
                            LanguageId = 2
                        };
                        SubcategoryLanguage ES = new SubcategoryLanguage()
                        {
                            Name = "Etibarnamələr",
                            SubcategoryId = 4,
                            LanguageId = 2
                        };
                        SubcategoryLanguage TQ = new SubcategoryLanguage()
                        {
                            Name = "Təsisçinin Qərarı",
                            SubcategoryId = 4,
                            LanguageId = 2
                        };
                        SubcategoryLanguage VF = new SubcategoryLanguage()
                        {
                            Name = "Vəsiyyətnamə Formaları",
                            SubcategoryId = 4,
                            LanguageId = 2
                        };
                        SubcategoryLanguage Akt = new SubcategoryLanguage()
                        {
                            Name = "Aktlar",
                            SubcategoryId = 4,
                            LanguageId = 2
                        };
                        SubcategoryLanguage QF = new SubcategoryLanguage()
                        {
                            Name = "Qərar Formaları",
                            SubcategoryId = 4,
                            LanguageId = 2
                        };
                        #endregion
                        #endregion
                        dbContext.SubcategoryLanguages.AddRange(EM, EF, VT, E, EK, EV, A, IE, AS, KS, V, BS, QIE, ET, ASM, PM, XM, BM, DM, ME, IM, HSUY, EUMEF, ES, TQ, VF, Akt, QF);
                        dbContext.SaveChanges();
                    }
                 //   UserAndRoleCreater.CreateAsync(scopedService, dbContext).Wait();

                }
            }

            webHost.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
