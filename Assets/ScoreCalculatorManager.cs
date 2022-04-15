using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculatorManager : MonoBehaviour
{
    public List<InputField> _inputfields;
    public List<Text> _avgs;
    public List<Text> _scores;
    public List<Text> _grades;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void result()
    {
        int score1 = int.Parse(_inputfields[0].text);
        int score2 = int.Parse(_inputfields[1].text);
        int score3 = int.Parse(_inputfields[2].text);
        int score4 = int.Parse(_inputfields[3].text);
        int score5 = int.Parse(_inputfields[4].text);

        float avg = (score1 + score2 + score3 + score4 + score5) / 5f;

        _avgs[0].text = avg + "";

        float sm1 = (4.5f * int.Parse(_inputfields[0].text)) / 100f;
        float sm2 = (4.5f * int.Parse(_inputfields[1].text)) / 100f;
        float sm3 = (4.5f * int.Parse(_inputfields[2].text)) / 100f;
        float sm4 = (4.5f * int.Parse(_inputfields[3].text)) / 100f;
        float sm5 = (4.5f * int.Parse(_inputfields[4].text)) / 100f;

        _scores[0].text = sm1 + "";
        _scores[1].text = sm2 + "";
        _scores[2].text = sm3 + "";
        _scores[3].text = sm4 + "";
        _scores[4].text = sm5 + "";

        float avg2 = (sm1 + sm2 + sm3 + sm4 + sm5) / 5f;
        _avgs[1].text = avg2 + "";

        for (int i = 0; i < _grades.Count; i++)
        {
            if (float.Parse(_scores[i].text) >= 4)
            {
                _grades[i].text = "A";
            }else if (float.Parse(_scores[i].text) >= 3.5)
            {
                _grades[i].text = "B";
            }
            else if (float.Parse(_scores[i].text) >= 3)
            {
                _grades[i].text = "C";
            }
            else
            {
                _grades[i].text = "D";
            }
        }

        if (avg2 >= 4)
        {
            _avgs[2].text = "A";
        }else if (avg2 >= 3.5)
        {
            _avgs[2].text = "B";
        }
        else if (avg2 >= 3)
        {
            _avgs[2].text = "C";
        }
        else
        {
            _avgs[2].text = "D";
        }
    }
}
