using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    [SerializeField] InputField _ilkInput, _ikinciInput;
    [SerializeField] int _sayi1, _sayi2, _sonuc;
    [SerializeField] Button toplamaBtb, cikarmabtn;
    [SerializeField] GameObject klavye1, klavye2, deleteBtn;

    [SerializeField] Text sonucText;
    bool toplamaMi;
    

    private void Start()
    {
         klavye1.SetActive(true);
        //KlavyeKontrol();

    }
    #region Klavye 1 Scrpits
    public void Tiklandi1()
    {
        _sayi1 = 1;
        _ilkInput.text = _sayi1.ToString();

    }
    public void Tiklandi2()
    {
        _sayi1 = 2;
        _ilkInput.text = _sayi1.ToString();
    }
    public void Tiklandi3()
    {
        _sayi1 = 3;
        _ilkInput.text = _sayi1.ToString();
    }
    public void Tiklandi4()
    {
        _sayi1 = 4;
        _ilkInput.text = _sayi1.ToString();
    }
    public void Tiklandi5()
    {
        _sayi1 = 5;
        _ilkInput.text = _sayi1.ToString();
    }
    public void Tiklandi6()
    {
        _sayi1 = 6;
        _ilkInput.text = _sayi1.ToString();
    }
    public void Tiklandi7()
    {
        _sayi1 = 7;
        _ilkInput.text = _sayi1.ToString();
    }
    public void Tiklandi8()
    {
        _sayi1 = 8;
        _ilkInput.text = _sayi1.ToString();
    }
    public void Tiklandi9()
    {
        _sayi1 = 9;
        _ilkInput.text = _sayi1.ToString();
    }
    #endregion

    #region Klavye 2 Scripts
    public void Tiklandi1K2()
    {
        _sayi2 = 1;
        _ikinciInput.text = _sayi2.ToString();

        Islemisonuclama();

    }
    public void Tiklandi2K2()
    {
        _sayi2 = 2;
        _ikinciInput.text = _sayi2.ToString();

        Islemisonuclama();

    }
    public void Tiklandi3K2()
    {
        _sayi2 = 3;
        _ikinciInput.text = _sayi2.ToString();

        Islemisonuclama();
    }
    public void Tiklandi4K2()
    {
        _sayi2 = 4;
        _ikinciInput.text = _sayi2.ToString();

        Islemisonuclama();
    }
    public void Tiklandi5K2()
    {
        _sayi2 = 5;
        _ikinciInput.text = _sayi2.ToString();

        Islemisonuclama();
    }
    public void Tiklandi6K2()
    {
        _sayi2 = 6;
        _ikinciInput.text = _sayi2.ToString();

        Islemisonuclama();
    }
    public void Tiklandi7K2()
    {
        _sayi2 = 7;
        _ikinciInput.text = _sayi2.ToString();

        Islemisonuclama();
    }
    public void Tiklandi8K2()
    {
        _sayi2 = 8;
        _ikinciInput.text = _sayi2.ToString();

        Islemisonuclama();
    }
    public void Tiklandi9K2()
    {
        _sayi2 = 9;
        _ikinciInput.text = _sayi2.ToString();

        Islemisonuclama();
    }
    #endregion


    public void BosMu()
    {

        if (_ilkInput.text != "")
        {
            toplamaBtb.interactable = true;
            cikarmabtn.interactable = true;
           // klavye1.SetActive(false);
        }
    }

   public void KlavyeKontrol()
    {
        //klavye1.SetActive(true);
        //switch (klavye1.activeInHierarchy)
        //{
        //    case true:
        //        klavye1.SetActive(false);
        //        klavye2.SetActive(true);
        //        break;
        //    case false:
        //        klavye1.SetActive(true);
        //        klavye2.SetActive(false);
        //        break;
        //}

        //if (klavye1.activeInHierarchy == true)
        //{
        //    klavye2.SetActive(false);
        //}
        //else
        //{
        //    klavye1.SetActive(false);
        //    klavye2.SetActive(true);
        //}
    }

    public void Topla()
    {
        klavye1.SetActive(false);
        klavye2.SetActive(true);
        toplamaMi = true;
    }
    public void Cikar()
    {
        klavye1.SetActive(false);
        klavye2.SetActive(true);
        toplamaMi = false;
    }
    
    public void ToplamaIslemiYap()
    {
        _sonuc = _sayi1 + _sayi2;
        sonucText.text = _sonuc.ToString();
    }

    public void CarpmaIslemiYap()
    {
        _sonuc = _sayi1 * _sayi2;
        sonucText.text = _sonuc.ToString();
    }

    public void CikarmaIslemiYap()
    {
        _sonuc = _sayi1 - _sayi2;
        sonucText.text = _sonuc.ToString();
    }
    void Islemisonuclama()
    {
        if (toplamaMi)
        {
            ToplamaIslemiYap();
        }
        else if (toplamaMi == false)
        {
            CikarmaIslemiYap();
        }
    }

   public void Delete()
    {
        switch (deleteBtn.activeInHierarchy)
        {
            case true:
                _ilkInput.text = " ";
                _ikinciInput.text = " ";
                sonucText.text = " ";
            break;
        }
    }
    public void DeleteInput1Gecis()
    {
        switch (deleteBtn.activeInHierarchy)
        {
            case true:
                deleteBtn.SetActive(true);
                klavye1.SetActive(true);
            break;
        }
    }
}
