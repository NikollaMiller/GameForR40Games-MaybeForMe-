using UnityEngine;
using System;
using UnityEngine.UI;

public class Localisation : MonoBehaviour
{
    [SerializeField] private Text _welcomeBar;

    private void Awake()
    {
        if (Application.systemLanguage == SystemLanguage.Russian)
        {
            _welcomeBar.text = "Здравствуй,это тестовое задание для R40Games Я уверен на 100 % из всех вакансии найдутся люди, которые проходили курсы и прочее и их тестовые игры буду лучше, но попытка не пытка и я доволен тем что опробовал себя было давольно весело, на самом деле на 6 день игра была уже готова(если я правильно себя понял) остальные дни я чисто занимался исправление багов и улучшением.";
        }
        else
        {
            _welcomeBar.text = "Hello this is a test task for R40Games I'm 100% sure of all vacancies there will be people who took courses and so on and their test games will be better, but the attempt is not torture and I am happy that I tried myself it was quite fun, in fact, on day 6 the game was already ready (if I understood myself correctly) the rest of the days I was purely engaged in fixing bugs and improving.";
        }
    }
}
