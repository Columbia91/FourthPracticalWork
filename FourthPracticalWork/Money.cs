using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthPracticalWork
{
    class Money
    {
        private int _faceValueOfTheBanknote;
        private int _amountOfBanknotes;

        public Money() {}
        public Money(int faceValueOfTheBanknote, int amountOfBanknotes)
        {
            _faceValueOfTheBanknote = faceValueOfTheBanknote;
            _amountOfBanknotes = amountOfBanknotes;
        }

        #region Методы доступа
        public int GetFaceValueOfTheBanknote()
        {
            return _faceValueOfTheBanknote;
        }
        public void SetFaceValueOfTheBanknote(int faceValueOfTheBanknote)
        {
            _faceValueOfTheBanknote = faceValueOfTheBanknote;
        }
        public int GetAmountOfBanknotes()
        {
            return _amountOfBanknotes;
        }
        public void SetAmountOfBanknotes(int amountOfBanknotes)
        {
            _amountOfBanknotes = amountOfBanknotes;
        }
        #endregion

        public void Show() // Вывести номинал и количество купюр
        {
            Console.WriteLine("Номинал купюры: " + GetFaceValueOfTheBanknote() +
                "\nКоличество купюр: " + GetAmountOfBanknotes());
        }
        public int GetBudget() // Расчитать сумму денег
        {
            return GetAmountOfBanknotes() * GetFaceValueOfTheBanknote();
        }
        public string IsEnoughForBuying(int priceOfAGood) // Достаточно ли средств для покупки товара
        {
            return priceOfAGood < GetBudget() ? "хватит денег" : "не хватит денег";
        }
        public int CountOfBoughtGoods(int priceOfAGood) // Количество купленных товаров
        {
            if (priceOfAGood < GetBudget())
            {
                return GetBudget() / priceOfAGood;
            }
            return 0;
        }
    }
}
