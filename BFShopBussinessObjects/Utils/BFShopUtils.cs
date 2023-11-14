﻿using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BFShopBussinessObjects
{
    public static class BFShopUtils
    {
        /// <summary>
        /// Check is valid fullname
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static bool IsValidFullName(string fullName)
        {
            var nameEle = fullName.Split(" ");
            bool isValid = false;

            foreach (var ele in nameEle)
            {
                var firstChar = ele.First();
                isValid = new Regex("^[A-Z]$").IsMatch(
                    firstChar.ToString());
            }

            return isValid;
        }

        /// <summary>
        /// Check valid email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;

            /// Email Regex validation:
            /// [\w\.\-]+ : many letters and numbers (also dot or hyphen)
            /// @ : 
            /// [\w\-]+ : many letters numbers or hyphen
            /// [\.\w]{2,3} : dot, many letters/numbers from 2-3 char

            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(email);
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            /// Email Regex validation:
            /// [\w\.\-]+ : many letters and numbers (also dot or hyphen)
            /// @ : 
            /// [\w\-]+ : many letters numbers or hyphen
            /// [\.\w]{2,3} : dot, many letters/numbers from 2-3 char

            var regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            return regex.IsMatch(password);
        }

        /// <summary>
        /// Check date valid
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsValidDate(string value, string pattern)
        {
            DateTime tempDate;
            bool validDate = DateTime.TryParseExact(value, pattern, DateTimeFormatInfo.InvariantInfo,
                DateTimeStyles.None, out tempDate);
            if (validDate)
                return true;
            else
                return false;
        }

        public static bool IsValidPattern(string value, string pattern)
        {
            var regex = new Regex(pattern);
            return regex.IsMatch(value);
        }

        public static bool IsNotNumericString(string value)
        {
            var pattern = new Regex(@"^([^0-9]*)$");
            return pattern.IsMatch(value);
        }

        public static double MoneyFormatToDouble(string value)
        {
            return Convert.ToDouble(value.Replace(".", ""));
        }
        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        public static bool ContainsLettersOrSpecialCharacters(string input)
        {
            return Regex.IsMatch(input, @"[\D]");
        }

        public static bool CheckProductIDExist(string proID, List<OrderDetail> odList)
        {
            foreach (var item in odList)
            {
                if (item.ProductId.Equals(proID))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isPhoneNum(string phoneNum) 
        {
            Regex regex = new Regex("^0?\\d{9,10}$");
            return regex.IsMatch(phoneNum);
        }
        public static bool NotIncludeSpecialCharacter(string inputString) 
        {
            Regex regex = new Regex("^[a-zA-Z0-9 ]*$");
            return regex.IsMatch(inputString);
        }
        public static AppSettings ConfigureAppSettings()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetSection("AppSettings").Get<AppSettings>();
        }
    }
}