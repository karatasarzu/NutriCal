# NutriCal (Calorie Tracking App)


This project was carried out together with [Burak Akyüz](https://github.com/burakyuz1) and [Ömer Faruk Eker](https://github.com/omerfe) for the BilgeAdam Academy term paper.

**NutriCal** is a calorie tracking program. By using this program, you can calculate the calories you take and burn, and report weekly/monthly. In addition, the program tells you the daily calorie intake by calculating the [MIFFLIN-ST JEOR](https://academic.oup.com/ajcn/article-abstract/51/2/241/4695104?redirectedFrom=fulltext) formula.

**Nutrical** is designed with C# language and Windows Form App .Net Framework. It used MS-SQL in database and used Entity Framework CodeFirst approach.

## USAGE SCENARIO

- In addition to user personal information (date of birth, weight, height), user needs a unique e-mail address and a strong password to register with the NutriCal system. Otherwise user cannot register!
- After logging in, the user can only add entry to that day's date. Cannot add entry for the previous day.
- User can add Exercise and Meal (also food in meals). 
- Exercises have a calorie value by default. He/she can change it if he/she wants. But it cannot change the default calories of the meals.
- The user can see the daily intake and burned calories. user can compare it with other users. He/she can see the daily calories that the system recommends to him/her.
- User can delete & update a meal or exercise that he/she added by mistake. He/she can create a special exercise or meal for himself/herself.

![PublicUI](https://github.com/burakyuz1/NutriCal/blob/master/NutriCal/Resources/nutrigif.gif?raw=true)
