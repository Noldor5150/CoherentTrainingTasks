using System;

namespace Task001
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
          
            
            //string id = "123";
            TextMaterial text = new TextMaterial("siple text", "text description", "12345678-1234-1234-1234-012345678912".CreateUniqueId());
            TextMaterial text2 = (TextMaterial)text.Clone();
            byte[] version1 = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            byte[] version2 = new byte[8] { 1, 1, 1, 1, 1, 1, 1, 1 };
            VideoMaterial video = new VideoMaterial("vidoecontent", 0 ,version1, "spalsh1", "picturecontent1", "video1", "12345678-1234-1234-1234-012345678913".CreateUniqueId());
            text.Description = "second text";
            VideoMaterial video2 = (VideoMaterial)video.Clone();
            video.Description = "changed";
            LinkToNetworkResource link = new LinkToNetworkResource("uri1", 0, "linkdescription,", "12345678-1234-1234-1234-012345678911".CreateUniqueId());
            LinkToNetworkResource link2 = (LinkToNetworkResource)link.Clone();
            link.Description = "changed";

            TrainingMaterial[] list = new TrainingMaterial[3] { text, text2, video };
            TrainingMaterial[] list2 = new TrainingMaterial[3] { video2, text2, video };

            TrainingLesson lesson = new TrainingLesson(list, version1, "lesson", "12345678-1234-1234-1234-012345678915".CreateUniqueId());
            TrainingLesson lesson2 = (TrainingLesson)lesson.Clone();

            lesson.Description = "changed";
            lesson.ArrayOfTrainingMaterials = list;
            Console.WriteLine(lesson.ArrayOfTrainingMaterials[0].Description);
            Console.WriteLine(lesson2.ArrayOfTrainingMaterials[0].Description);
            Console.WriteLine(lesson2.GetLessonType(list));
            Console.WriteLine(lesson.GetLessonType(list2));
            
        }
    }
}
