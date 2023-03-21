using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class QuestionLoaderScience : MonoBehaviour
{




    // Public arrays to store the question data
    public static string[] question1 = new string[8];
    public static string[] question2 = new string[8];
    public static string[] question3 = new string[8];
    public static string[] question4 = new string[8];
    public static string[] question5 = new string[8];
    public static string[] question6 = new string[8];
    public static string[] question7 = new string[8];
    public static string[] question8 = new string[8];
    public static string[] question9 = new string[8];
    public static string[] question10 = new string[8];
    public static string[] question11 = new string[8];
    public static string[] question12 = new string[8];
    public static string[] question13 = new string[8];
    public static string[] question14 = new string[8];
    public static string[] question15 = new string[8];
    public static string[] question16 = new string[8];
    public static string[] question17 = new string[8];
    public static string[] question18 = new string[8];
    public static string[] question19 = new string[8];
    public static string[] question20 = new string[8];
    public static string[] question21 = new string[8];
    public static string[] question22 = new string[8];
    public static string[] question23 = new string[8];
    public static string[] question24 = new string[8];
    public static string[] question25 = new string[8];
    public static string[] question26 = new string[8];
    public static string[] question27 = new string[8];
    public static string[] question28 = new string[8];
    public static string[] question29 = new string[8];
    public static string[] question30 = new string[8];


    public IEnumerator Start()
    {
        int biologyquestioncount = calculatescienceQs.biologyQuestionCount;
        int chemistryquestioncount = calculatescienceQs.chemistryQuestionCount;
        int physicsquestioncount = calculatescienceQs.physicsQuestionCount;
        Debug.Log("values are : " + biologyquestioncount + " " + chemistryquestioncount + " " + physicsquestioncount);
        // Create a dictionary to store the question data for each topic
        Dictionary<string, List<string[]>> questionData = new Dictionary<string, List<string[]>>();

        // Add each topic to the dictionary with an empty list to store the question data
        questionData.Add("biology", new List<string[]>());
        questionData.Add("chemistry", new List<string[]>());
        questionData.Add("physics", new List<string[]>());

        // Get the question data from the database using a PHP script
        string url = "http://localhost/unity/QuestionRetreival/scienceQretreival.php?" +
                     "biologyquestioncount=" + biologyquestioncount +
                     "&chemistryquestioncount=" + chemistryquestioncount +
                     "&physicsquestioncount=" + physicsquestioncount;

        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log("Error retrieving question data: " + www.error);
        }
        else
        {
            //Debug.Log(www.result);
            // Split the response into individual rows
            string[] rows = www.downloadHandler.text.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);

            // Loop through each row and add it to the appropriate list in the dictionary
            foreach (string row in rows)
            {
                string[] values = row.Split(new char[] { '|' });
                string topic = values[7].ToLower();
                questionData[topic].Add(values);
            }
        }

        // Loop through each topic and populate the arrays with the appropriate number of questions
        int i = 0;
        foreach (KeyValuePair<string, List<string[]>> topic in questionData)
        {
            int count = 0;
            switch (topic.Key)
            {
                case "biology":
                    count = biologyquestioncount;
                    break;
                case "chemistry":
                    count = chemistryquestioncount;
                    break;
                case "physics":
                    count = physicsquestioncount;
                    break;
            }

            // Randomly select questions from the list for this topic until the count is reached
            for (int j = 0; j < count; j++)
            {
                int index = Random.Range(0, Mathf.Max(0, topic.Value.Count - 1));
                string[] question = topic.Value[index];
                switch (i)
                {
                    case 0:
                        question1 = question;
                        break;
                    case 1:
                        question2 = question;
                        break;
                    case 2:
                        question3 = question;
                        break;
                    case 3:
                        question4 = question;
                        break;
                    case 4:
                        question5 = question;
                        break;
                    case 5:
                        question6 = question;
                        break;
                    case 6:
                        question7 = question;
                        break;
                    case 7:
                        question8 = question;
                        break;
                    case 8:
                        question9 = question;
                        break;
                    case 9:
                        question10 = question;
                        break;
                    case 10:
                        question11 = question;
                        break;
                    case 11:
                        question12 = question;
                        break;
                    case 12:
                        question13 = question;
                        break;
                    case 13:
                        question14 = question;
                        break;
                    case 14:
                        question15 = question;
                        break;
                    case 15:
                        question16 = question;
                        break;
                    case 16:
                        question17 = question;
                        break;
                    case 17:
                        question18 = question;
                        break;
                    case 18:
                        question19 = question;
                        break;
                    case 19:
                        question20 = question;
                        break;
                    case 20:
                        question21 = question;
                        break;
                    case 21:
                        question22 = question;
                        break;
                    case 22:
                        question23 = question;
                        break;
                    case 23:
                        question24 = question;
                        break;
                    case 24:
                        question25 = question;
                        break;
                    case 25:
                        question26 = question;
                        break;
                    case 26:
                        question27 = question;
                        break;
                    case 27:
                        question28 = question;
                        break;
                    case 28:
                        question29 = question;
                        break;
                    case 29:
                        question30 = question;
                        break;
                }
                topic.Value.RemoveAt(index);
                i++;

            }
        }
        Debug.Log("science questions created");
 

    }

}
