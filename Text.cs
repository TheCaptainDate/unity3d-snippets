        // Формируем правильное слово в зависимости от числа.
        // Способ через строки - костыльный, простой, медленный.
        // Умнее обычно не нужно :)
        
        string word = "";

        var len = _count.ToString().Length;
        var sub = _count.ToString().Substring(len - 1, len);

        switch (sub)
        {
            case "1":
                word = "зерно";
                break;
            case "2":
            case "3":
            case "4":
                word = "зерна";
                break;
            default:
                word = "зерен";
                break;
        }

        CountText.text = $"{_count.ToString()} {word}";
