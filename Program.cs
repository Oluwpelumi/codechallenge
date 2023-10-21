
int[] arr = {1,8,100,2,100,4,8,3,7};
System.Console.WriteLine(MaxArea(arr));


int MaxArea(int[] height) 
{
    // int maxAreaOfWater = 0;
    // int y = height.Length - 1;

    // for (int x = 0; x <= y; x++)  //x is left and y is right
    // {
    //     int width;
    //     if(x==y && height[x-1]>height[y])
    //     {
    //         width = y - x +1;
    //     }
    //     else
    //     {
    //         width = y - x;
    //     }
    //     int currentWater = Math.Min(height[x], height[y]) * width; 
    //     maxAreaOfWater = Math.Max(maxAreaOfWater, currentWater);

    //     if (height[x] > height[y])
    //     {
    //         y--;
    //     }

    // }

    // return maxAreaOfWater;

    int maxAreaOfWater = 0;
    int x = 0;
    int y = height.Length - 1;

    while (x < y)
    {
        int width = y - x;
        int currentWater = Math.Min(height[x], height[y]) * width;
        maxAreaOfWater = Math.Max(maxAreaOfWater, currentWater);

        if (height[x] < height[y])
        {
            x++;
        }
        else
        {
            y--;
        }
    }

    return maxAreaOfWater;
}










// using System.Text.RegularExpressions;


// var inputValue = "0.111.168@1.1";
// var sp = inputValue.Split(".");
// var check = false;
// for (int i = 0; i < sp.Length-1; i++)
// {
//     var a = ConvertStringToIntBelow255(sp[i]);
//     var b = CheckStartsWithLeadingZero(sp[i]);
//     var c = CheckSpecialCharacters(sp[i]);
//     if (a && b && c)
//     {
//         check = true;
//     }
//     else
//     {
//         check = false;
//         break;
//     }
// }

// if (check)
// {
//     System.Console.WriteLine("Valid IP Address");
// }
// else
// {
//     System.Console.WriteLine("Invalid IP Address");
// }



// bool ConvertStringToIntBelow255(string m)
// {
//     int x;
//     var k = int.TryParse(m,out x);

//     if ((x < 255) && k)
//     {
//         return true;
//     }
//     return false;
// }


// bool CheckStartsWithLeadingZero(string m)
// {
//     if (m.Length > 1)
//     {
//         if (m.StartsWith('0'))
//         {
//             return false;
//         }
//         return true;
//     }
//     return true;
// }

// bool CheckSpecialCharacters(string m)
// {
//     string pattern = @"[^a-zA-Z0-9\s]";
//     bool containsSpecialCharacters = Regex.IsMatch(m, pattern);
//     if (!containsSpecialCharacters)
//     {
//         return true;
//     }
//     return false;
// }


