using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] private int _maxGuess = 1000;
    [SerializeField] private int _minGuess = 1;
    [SerializeField] private TextMeshProUGUI _guessText;

    private int _guess = 500;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    private void NextGuess()
	{
        _guess = Random.Range(_minGuess, _maxGuess+1);
        _guessText.text = _guess.ToString();
    }

    public void OnPressHigher()
	{
        _minGuess = _guess +1;
        NextGuess();

    }

	public void OnPressLower()
	{
        _maxGuess = _guess -1;
        NextGuess();
    }
	
}
