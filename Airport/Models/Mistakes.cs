using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Airport.View
{
    public class Mistakes
    {
        /// <summary>
        /// Проверяет есть ли в тексте только буквы
        /// </summary>
        /// <param name="text">Текст который будем проверять</param>
        /// <returns></returns>
        public bool mistakes(string text)
        {
            if (text == null ||
                text == "" ||
                Regex.IsMatch(text, @"^[0-9]+$"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Проверяет есть ли в тексте только цифры и буквы
        /// </summary>
        /// <param name="text">Текст который будем проверять</param>
        /// <param name="numbers">Есть ли цифры</param>
        /// <returns></returns>
        public bool mistakes(string text, bool numbers)
        {
            if (numbers == true)
            {
                if (text == null ||
                   text == "")
                {
                    return true;
                }
            }
            else
            {
                return mistakes(text);
            }
            return false;
        }
    }
    
}
