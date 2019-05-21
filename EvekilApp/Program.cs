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
                    if (!dbContext.Languages.Any())
                    {
                        #region Languages
                        Language en = new Language()
                        {
                            Key = "en",
                            Value = "English"
                        };
                        Language az = new Language()
                        {
                            Key = "az",
                            Value = "Azerbaijan"
                        };
                        #endregion
                        dbContext.Languages.AddRange(en, az);
                        dbContext.SaveChanges();
                    }
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
                    if (!dbContext.Categories.Any())
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
                        dbContext.Categories.AddRange(category, category2, category3, category4);
                        dbContext.SaveChanges();


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
                    }
                    if (!dbContext.Subcategories.Any())
                    {
                        #region Subcategories

                        #region InsanResurslariSubcategoriyasi
                        Subcategory _EM = new Subcategory()
                        {
                            CategoryId = 1
                        };
                        Subcategory _EF = new Subcategory()
                        {
                            CategoryId = 1
                        };
                        Subcategory _VT = new Subcategory()
                        {
                            CategoryId = 1
                        };
                        Subcategory _E = new Subcategory()
                        {
                            CategoryId = 1
                        };
                        Subcategory _EK = new Subcategory()
                        {
                            CategoryId = 1
                        };
                        Subcategory _EV = new Subcategory()
                        {
                            CategoryId = 1
                        };
                        Subcategory _A = new Subcategory()
                        {
                            CategoryId = 1
                        };
                        dbContext.Subcategories.AddRange(_EM, _EF, _VT, _E, _EK, _EV, _A);
                        dbContext.SaveChanges();

                        SubcategoryLanguage EM = new SubcategoryLanguage()
                        {
                            Name = "Əmək Müqaviləsi",
                            SubcategoryId = 1,
                            LanguageId = 2
                        };
                        SubcategoryLanguage EF = new SubcategoryLanguage()
                        {
                            Name = "Əmr Formaları",
                            SubcategoryId = 2,
                            LanguageId = 2
                        };
                        SubcategoryLanguage VT = new SubcategoryLanguage()
                        {
                            Name = "Vəzifə Təlimatları",
                            SubcategoryId = 3,
                            LanguageId = 2
                        };
                        SubcategoryLanguage E = new SubcategoryLanguage()
                        {
                            Name = "Ərizələr",
                            SubcategoryId = 4,
                            LanguageId = 2
                        };
                        SubcategoryLanguage EK = new SubcategoryLanguage()
                        {
                            Name = "Əmr Kitabları",
                            SubcategoryId = 5,
                            LanguageId = 2
                        };
                        SubcategoryLanguage EV = new SubcategoryLanguage()
                        {
                            Name = "Ezamiyyə Vərəqələri",
                            SubcategoryId = 6,
                            LanguageId = 2
                        };
                        SubcategoryLanguage A = new SubcategoryLanguage()
                        {
                            Name = "Aktlar",
                            SubcategoryId = 7,
                            LanguageId = 2
                        };
                        #endregion

                        #region MehkemeSenedleriSubcategoriyasi
                        Subcategory _IE = new Subcategory()
                        {
                            CategoryId = 2
                        };
                        Subcategory _AS = new Subcategory()
                        {
                            CategoryId = 2
                        };
                        Subcategory _KS = new Subcategory()
                        {
                            CategoryId = 2
                        };
                        Subcategory _V = new Subcategory()
                        {
                            CategoryId = 2
                        };
                        Subcategory _BS = new Subcategory()
                        {
                            CategoryId = 2
                        };
                        Subcategory _QIE = new Subcategory()
                        {
                            CategoryId = 2
                        };
                        Subcategory _ET = new Subcategory()
                        {
                            CategoryId = 2
                        };
                        dbContext.Subcategories.AddRange(_IE, _AS, _KS, _V, _BS, _QIE, _ET);
                        dbContext.SaveChanges();

                        SubcategoryLanguage IE = new SubcategoryLanguage()
                        {
                            Name = "İddia Ərizələri",
                            SubcategoryId = 8,
                            LanguageId = 2
                        };
                        SubcategoryLanguage AS = new SubcategoryLanguage()
                        {
                            Name = "Apelyasiya Şikayətləri",
                            SubcategoryId = 9,
                            LanguageId = 2
                        };
                        SubcategoryLanguage KS = new SubcategoryLanguage()
                        {
                            Name = "Kassasiya Şikayətləri",
                            SubcategoryId = 10,
                            LanguageId = 2
                        };
                        SubcategoryLanguage V = new SubcategoryLanguage()
                        {
                            Name = "Vəsatətlər",
                            SubcategoryId = 11,
                            LanguageId = 2
                        };
                        SubcategoryLanguage BS = new SubcategoryLanguage()
                        {
                            Name = "Barışıq Sazişləri",
                            SubcategoryId = 12,
                            LanguageId = 2
                        };
                        SubcategoryLanguage QIE = new SubcategoryLanguage()
                        {
                            Name = "Qarşılıqlı İddia Ərizələri",
                            SubcategoryId = 13,
                            LanguageId = 2
                        };
                        SubcategoryLanguage ET = new SubcategoryLanguage()
                        {
                            Name = "Etirazlar",
                            SubcategoryId = 14,
                            LanguageId = 2
                        };
                        #endregion

                        #region MuqavilelerSubcategoriyasi
                        Subcategory _ASM = new Subcategory()
                        {
                            CategoryId = 3
                        };
                        Subcategory _PM = new Subcategory()
                        {
                            CategoryId = 3
                        };
                        Subcategory _XM = new Subcategory()
                        {
                            CategoryId = 3
                        };
                        Subcategory _BM = new Subcategory()
                        {
                            CategoryId = 3
                        };
                        Subcategory _DM = new Subcategory()
                        {
                            CategoryId = 3
                        };
                        Subcategory _ME = new Subcategory()
                        {
                            CategoryId = 3
                        };
                        Subcategory _IM = new Subcategory()
                        {
                            CategoryId = 3
                        };
                        dbContext.Subcategories.AddRange(_ASM, _PM, _XM, _BM, _DM, _ME, _IM);
                        dbContext.SaveChanges();

                        SubcategoryLanguage ASM = new SubcategoryLanguage()
                        {
                            Name = "Alğı-satqı Müqavilələri",
                            SubcategoryId = 15,
                            LanguageId = 2
                        };
                        SubcategoryLanguage PM = new SubcategoryLanguage()
                        {
                            Name = "Podrat Müqavilələri",
                            SubcategoryId = 16,
                            LanguageId = 2
                        };
                        SubcategoryLanguage XM = new SubcategoryLanguage()
                        {
                            Name = "Xidmət Müqavilələri",
                            SubcategoryId = 17,
                            LanguageId = 2
                        };
                        SubcategoryLanguage BM = new SubcategoryLanguage()
                        {
                            Name = "Borc Müqavilələri",
                            SubcategoryId = 18,
                            LanguageId = 2
                        };
                        SubcategoryLanguage DM = new SubcategoryLanguage()
                        {
                            Name = "Daşınma Müqavilələri",
                            SubcategoryId = 19,
                            LanguageId = 2
                        };
                        SubcategoryLanguage ME = new SubcategoryLanguage()
                        {
                            Name = "Müqavilələrə Əlavələr",
                            SubcategoryId = 20,
                            LanguageId = 2
                        };
                        SubcategoryLanguage IM = new SubcategoryLanguage()
                        {
                            Name = "İcarə Müqavilələri" +
                            "",
                            SubcategoryId = 21,
                            LanguageId = 2
                        };
                        #endregion

                        #region SairSenedlerSubcategoriyasi
                        Subcategory _HSUY = new Subcategory()
                        {
                            CategoryId = 4
                        };
                        Subcategory _EUMEF = new Subcategory()
                        {
                            CategoryId = 4
                        };
                        Subcategory _ES = new Subcategory()
                        {
                            CategoryId = 4
                        };
                        Subcategory _TQ = new Subcategory()
                        {
                            CategoryId = 4
                        };
                        Subcategory _VF = new Subcategory()
                        {
                            CategoryId = 4
                        };
                        Subcategory _Akt = new Subcategory()
                        {
                            CategoryId = 4
                        };
                        Subcategory _QF = new Subcategory()
                        {
                            CategoryId = 4
                        };
                        dbContext.Subcategories.AddRange(_HSUY, _EUMEF, _ES, _TQ, _VF, _Akt, _QF);
                        dbContext.SaveChanges();

                        SubcategoryLanguage HSUY = new SubcategoryLanguage()
                        {
                            Name = "Hüquqi Şəxsin Ümumi Yığıncağının Qərarı",
                            SubcategoryId = 22,
                            LanguageId = 2
                        };
                        SubcategoryLanguage EUMEF = new SubcategoryLanguage()
                        {
                            Name = "Əfv üçün Müraciət Ərizə Forması",
                            SubcategoryId = 23,
                            LanguageId = 2
                        };
                        SubcategoryLanguage ES = new SubcategoryLanguage()
                        {
                            Name = "Etibarnamələr",
                            SubcategoryId = 24,
                            LanguageId = 2
                        };
                        SubcategoryLanguage TQ = new SubcategoryLanguage()
                        {
                            Name = "Təsisçinin Qərarı",
                            SubcategoryId = 25,
                            LanguageId = 2
                        };
                        SubcategoryLanguage VF = new SubcategoryLanguage()
                        {
                            Name = "Vəsiyyətnamə Formaları",
                            SubcategoryId = 26,
                            LanguageId = 2
                        };
                        SubcategoryLanguage Akt = new SubcategoryLanguage()
                        {
                            Name = "Aktlar",
                            SubcategoryId = 27,
                            LanguageId = 2
                        };
                        SubcategoryLanguage QF = new SubcategoryLanguage()
                        {
                            Name = "Qərar Formaları",
                            SubcategoryId = 28,
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
