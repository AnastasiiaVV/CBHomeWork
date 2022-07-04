using System;

namespace Indexers
{
    class Dictionary
    {
        private string[] value1 = new string[5];
        private string[] value2 = new string[5];
        private string[] value3 = new string[5];

        public Dictionary()
        {
            value1[0] = "книга"; value2[0] = "book"; value3[0] = "книга";
            value1[1] = "ручка"; value2[1] = "pen"; value3[1] = "ручка";
            value1[2] = "солнце"; value2[2] = "sun"; value3[2] = "сонце";
            value1[3] = "яблоко"; value2[3] = "apple"; value3[3] = "яблуко";
            value1[4] = "стол"; value2[4] = "table"; value3[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < value1.Length; i++)
                {
                    if (value1[i] == index)
                    {
                        return value1[i] + " - " + value2[i] + " - " + value3[i];
                    }
                }

                for (int i = 0; i < value2.Length; i++) {
                    if (value2[i] == index) {
                        return value2[i] + " - " + value1[i] + " - " + value3[i];
                    }
                }

                for (int i = 0; i < value3.Length; i++) {
                    if (value3[i] == index) {
                        return value3[i] + " - " + value1[i] + " - " + value2[i];
                    }
                }
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < value1.Length)
                {
                    return value1[index] + " - " + value2[index] + " - " + value3[index];
                }
                    
                else
                    return "Попытка обращения за пределы массива.";
            }
        }      
    }
}
