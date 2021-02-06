using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;

namespace Questionnaire.Models
{
    public static class MySqlModel
    {
        public struct Question
        {
            public int id;
            public string question;
        }

        public struct Answer
        {
            public string province;
            public string count;
        }

        static string ConnectionString = "server=185.10.73.229;uid=mortizanourani;pwd=t4dkh:ujcmsrlgixYfwy;database=questionnaire;";

        public static List<Question> Read(int pageId)
        {
            List<Question> Result = new List<Question>();
            string Query = string.Format("SELECT * FROM questions WHERE page = {0}", pageId);
            using (var Connection = new MySqlConnection(ConnectionString))
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                MySqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Question Q = new Question();
                    Q.id = (int) Reader["questionId"];
                    Q.question = Reader["question"].ToString().Replace('ي', 'ی').Replace('ة', 'ه');
                    Result.Add(Q);
                }
            }

            return Result;
        }

        public static int createPerson(FormCollection personInformation)
        {
            int personId = new int();

            string Columns = string.Format("{0}, {1}, {2}, {3}",
                "age, gender, province, marital, job, income, education",
                "infection, disease, diagnosis, duration, headach1, headach2, cough1, cough2, weakness1, weakness2, anosmia1, anosmia2, prosmia1, prosmia2, taste1, taste2, insomnia1, insomnia2, urination1, urination2",
                "hypertension, diabetes, overweight, cardiovascular, respiratorylung, kidney, cancer, ms",
                "irib, iribchannel, satellite, satellitechannel, instagram, instagrampage, telegram, telegramchannel, twitter, twitterpage, whatsapp, friends, website, websiteaddress, newspaper, newspapertitle");

            var age = (personInformation["age"] != null) ? personInformation["age"] : "99";
            var gender = (personInformation["gender"] != null) ? personInformation["gender"] : "99";
            var province = string.Format("'{0}'", personInformation["province"]);
            var marital = (personInformation["marital"] != null) ? personInformation["marital"] : "99";
            var job = (personInformation["job"] != null) ? personInformation["job"] : "99";
            var income = (personInformation["income"] != null) ? personInformation["income"] : "99";
            var education = (personInformation["education"] != null) ? personInformation["education"] : "99";

            var infection = (personInformation["infection"] != null) ? personInformation["infection"] : "99";
            var disease = (personInformation["disease"] != null) ? personInformation["disease"] : "99";
            var diagnosis = (personInformation["diagnosis"] != null) ? personInformation["diagnosis"] : "99";
            var duration = (personInformation["duration"] != null) ? personInformation["duration"] : "99";

            var headach1 = (personInformation["headach1"] != null) ? personInformation["headach1"] : "99";
            var headach2 = string.Format("'{0}'", personInformation["headach2"]);
            var cough1 = (personInformation["cough1"] != null) ? personInformation["cough1"] : "99";
            var cough2 = string.Format("'{0}'", personInformation["cough2"]);
            var weakness1 = (personInformation["weakness1"] != null) ? personInformation["weakness1"] : "99";
            var weakness2 = string.Format("'{0}'", personInformation["weakness2"]);
            var anosmia1 = (personInformation["anosmia1"] != null) ? personInformation["anosmia1"] : "99";
            var anosmia2 = string.Format("'{0}'", personInformation["anosmia2"]);
            var prosmia1 = (personInformation["prosmia1"] != null) ? personInformation["prosmia1"] : "99";
            var prosmia2 = string.Format("'{0}'", personInformation["prosmia2"]);
            var taste1 = (personInformation["taste1"] != null) ? personInformation["taste1"] : "99";
            var taste2 = string.Format("'{0}'", personInformation["taste2"]);
            var insomnia1 = (personInformation["insomnia1"] != null) ? personInformation["insomnia1"] : "99";
            var insomnia2 = string.Format("'{0}'", personInformation["insomnia2"]);
            var urination1 = (personInformation["urination1"] != null) ? personInformation["urination1"] : "99";
            var urination2 = string.Format("'{0}'", personInformation["urination2"]);

            var hypertension = (personInformation["hypertension"] == "on") ? 1 : 0;
            var diabetes = (personInformation["diabetes"] == "on") ? 1 : 0;
            var overweight = (personInformation["overweight"] == "on") ? 1 : 0;
            var cardiovascular = (personInformation["cardiovascular"] == "on") ? 1 : 0;
            var respiratorylung = (personInformation["respiratorylung"] == "on") ? 1 : 0;
            var kidney = (personInformation["kidney"] == "on") ? 1 : 0;
            var cancer = (personInformation["cancer"] == "on") ? 1 : 0;
            var ms = (personInformation["ms"] == "on") ? 1 : 0;

            var irib = (personInformation["irib"] == "on") ? 1 : 0;
            var iribchannel = string.Format("'{0}'", personInformation["iribchannel"]);
            var satellite = (personInformation["satellite"] == "on") ? 1 : 0;
            var satellitechannel = string.Format("'{0}'", personInformation["satellitechannel"]);
            var instagram = (personInformation["instagram"] == "on") ? 1 : 0;
            var instagrampage = string.Format("'{0}'", personInformation["instagrampage"]);
            var telegram = (personInformation["telegram"] == "on") ? 1 : 0;
            var telegramchannel = string.Format("'{0}'", personInformation["telegramchannel"]);
            var twitter = (personInformation["twitter"] == "on") ? 1 : 0;
            var twitterpage = string.Format("'{0}'", personInformation["twitterpage"]);
            var whatsapp = (personInformation["whatsapp"] == "on") ? 1 : 0;
            var friends = (personInformation["friends"] == "on") ? 1 : 0;
            var website = (personInformation["website"] == "on") ? 1 : 0;
            var websiteaddress = string.Format("'{0}'", personInformation["websiteaddress"]);
            var newspaper = (personInformation["newspaper"] == "on") ? 1 : 0;
            var newspapertitle = string.Format("'{0}'", personInformation["newspapertitle"]);

            string Answers = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}",
                age, gender, province, marital, job, income, education,
                infection + ", " + disease + ", " + diagnosis + ", " + duration + ", " +
                headach1 + ", " + headach2 + ", " + cough1 + ", " + cough2 + ", " +
                weakness1 + ", " + weakness2 + ", " + anosmia1 + ", " + anosmia2 + ", " +
                prosmia1 + ", " + prosmia2 + ", " + taste1 + ", " + taste2 + ", " +
                insomnia1 + ", " + insomnia2 + ", " + urination1 + ", " + urination2,
                hypertension + ", " + diabetes + ", " + overweight + ", " + cardiovascular + ", " +
                respiratorylung + ", " + kidney + ", " + cancer + ", " + ms,
                irib + ", " + iribchannel + ", " + satellite + ", " + satellitechannel + ", " +
                instagram + ", " + instagrampage + ", " + telegram + ", " + telegramchannel + ", " +
                twitter + ", " + twitterpage + ", " + whatsapp + ", " + friends + ", " +
                website + ", " + websiteaddress + ", " + newspaper + ", " + newspapertitle);

            string Query = string.Format("INSERT INTO answers ({0}) VALUES ({1})", Columns, Answers);
            using (var Connection = new MySqlConnection(ConnectionString))
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                if (Command.ExecuteNonQuery() > 0)
                {
                    // Read the last personId
                    Query = string.Format("SELECT * FROM answers ORDER BY id DESC LIMIT 1");
                    Command = new MySqlCommand(Query, Connection);
                    personId = (int)Command.ExecuteScalar();
                }
            }

            return personId;
        }

        public static bool updateAnswers(string personId, FormCollection questionAnswers)
        {
            int index = 1;
            var Values = "";
            foreach(var key in questionAnswers.AllKeys)
            {
                if (index == 1)
                    Values += string.Format("{0}={1}", key.ToString(), questionAnswers[key.ToString()]);
                else
                    Values += string.Format(", {0}={1}", key.ToString(), questionAnswers[key.ToString()]);

                index++;
            }

            string Query = string.Format("UPDATE answers SET {0} WHERE id = {1}", Values, personId);
            using (var Connection = new MySqlConnection(ConnectionString))
            {
                Connection.Open();
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                if (Command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static List<Answer> Result()
        {
            List<Answer> Res = new List<Answer>();
            string ambiCondition = "(ambi1 + ambi2 + ambi3 + ambi4 + ambi5 + ambi6 + ambi7 + ambi8 + ambi9 + ambi10 + ambi11 + ambi12 + ambi13 + ambi14 + ambi15 + ambi16 + ambi17 + ambi18 + ambi19 + ambi20 + ambi21 + ambi22 + ambi23 + ambi24 + ambi25 + ambi26 + ambi27)  < 417";
            string darkCondition = "(dark1 + dark2 + dark3 + dark4 + dark5 + dark6 + dark7 + dark8 + dark9 + dark10 + dark11 + dark12) < 360";
            string covidCondition = "(covid1 + covid2 + covid3 + covid4 + covid5 + covid6 + covid7 + covid8 + covid9 + covid10 + covid11 + covid12 + covid13 + covid14 + covid15 + covid16 + covid17 + covid18) < 357";
            string emotionCondition = "(emotion1 + emotion2 + emotion3 + emotion4 + emotion5 + emotion6 + emotion7 + emotion8 + emotion9 + emotion10) < 346";
            string Query = string.Format("SELECT province, count(*) FROM answers WHERE ({0}) AND ({1}) AND ({2}) AND ({3}) GROUP BY province", ambiCondition, darkCondition, covidCondition, emotionCondition);
            string CountQuery = string.Format("SELECT COUNT(*) FROM answers WHERE ({0}) AND ({1}) AND ({2}) AND ({3})", ambiCondition, darkCondition, covidCondition, emotionCondition);
            using (var Connection = new MySqlConnection(ConnectionString))
            {
                Connection.Open();
                MySqlCommand CountCommand = new MySqlCommand(CountQuery, Connection);
                Res.Add(new Answer() { province = "مجموع", count = CountCommand.ExecuteScalar().ToString() });

                MySqlCommand Command = new MySqlCommand(Query, Connection);
                MySqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Answer A = new Answer();
                    A.province = Reader[0].ToString();
                    A.count = Reader[1].ToString();
                    Res.Add(A);
                }
                Reader.Close();
            }

            return Res;
        }
    }
}