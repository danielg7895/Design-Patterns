using System;

namespace ChainOfResponsibilityPattern
{
    class ChainOfResponsibility
    {
        public void Main()
        {
            // chain creation
            JapaneseTeacher japaneseTeacher = new JapaneseTeacher();
            EnglishTeacher englishTeacher = new EnglishTeacher();
            ChineseTeacher chineseTeacher = new ChineseTeacher();
            FrenchTeacher frenchTeacher = new FrenchTeacher();

            japaneseTeacher
                .SetNextTeacher(englishTeacher)
                .SetNextTeacher(chineseTeacher)
                .SetNextTeacher(frenchTeacher);

            Language english = new Language("French");
            japaneseTeacher.GiveJob(english);
        }
    }

    public class Language
    {
        public string Name { get; set; }

        public Language(string name)
        {
            Name = name;
        }
    }

    public abstract class LanguageTeacher
    {
        protected LanguageTeacher _teacher;
        Language _language;

        public LanguageTeacher SetNextTeacher(LanguageTeacher teacher)
        {
            _teacher = teacher;
            return teacher;
        }

        // HandleRequest
        public virtual void GiveJob(Language language)
        {
            _language = language;
            if (_teacher != null)
            {
                _teacher.GiveJob(language);
            } 
            else
            {
                Console.WriteLine("There are not teachers for that job!");
            }
        }

    }

    public class EnglishTeacher : LanguageTeacher
    {
        public override void GiveJob(Language language)
        {
            if (language.Name == "English")
            {
                Console.WriteLine($"This {language.Name} is for me! i'm an English teacher.");
            }
            else
            {
                base.GiveJob(language);
            }
        }
    }

    public class JapaneseTeacher : LanguageTeacher
    {
        public override void GiveJob(Language language)
        {
            if (language.Name == "Japanese")
            {
                Console.WriteLine($"This {language.Name} is for me! i'm an Japanese teacher.");
            }
            else
            {
                base.GiveJob(language);
            }
        }

    }

    public class FrenchTeacher : LanguageTeacher
    {
        public override void GiveJob(Language language)
        {
            if (language.Name == "French")
            {
                Console.WriteLine($"This {language.Name} is for me! i'm an French teacher.");
            }
            else
            {
                base.GiveJob(language);
            }
        }
    }

    public class ChineseTeacher : LanguageTeacher
    {
        public override void GiveJob(Language language)
        {
            if (language.Name == "Chinese")
            {
                Console.WriteLine($"This {language.Name} is for me! i'm an Chinese teacher.");
            }
            else
            {
                base.GiveJob(language);
            }
        }

    }


}
