   M S B A M L   `   `   `  ????B  >PetsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PetsAppPetsApp  5   	       PetsApp.PetStore   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:PetsApp     5   	     ? WindowStartupLocation$  CenterScreen=?5   	    ? 
ResizeMode$ NoResize=?5	   	    ? Title$ PetStore??5
   	   $	??450??6   $	??800??6'   .??5      ? .+?5   
   ?? $??30(?6   $??224,0,184,363q?6   .??65   Welcome to the Pet Store6O   ?? 5   
   -   5         ??Name$ GetCat??5   4   $??50(?6&   $??9,110,611,235q?6D   .??6[   🐈6_   ?? 5   
   $
??Left=?6   $??20(?6+   $??79,197,0,183q?69   .??6O   Cat6T   ?? 5   
   -   5        $ GetPlant??5   7   $??50(?6)   $??208,110,400,235q?6I   .??6b   🌱6f   ?? 5   
   $
??Left=?6   $??20(?6+   $??277,197,0,183q?69   .??6P   Plant6W   ?? 5   
   -   5        $ GetDog??5   4   $??50(?6&   $??420,110,198,235q?6D   .??6]   🐕6a   ?? 5   
   $
??Left=?6   $??20(?6+   $??487,198,0,170q?69   .??6P   Dog6U   ?? 5   
   -   5        $ GetFish??5   6   $??50(?6(   $??614,110,10,235q?6G   .??6_   🐟6c   ?? 5   
   $??20(?6   $
??Left=?6   $??680,198,0,182q?69   .??6P   Fish6V   ?? 5    
   $??169,300,469,0q?6   $	??Top=?6'   .??6?   Name:6F   ?? 5!   
   -   5         ??Name$ PetName??5!      
???????$	??Top=?6:    ?? TextAlignment$ Center=?6R   $??242,304,242,0q?6i   6?   ?? 5$   
   -   5        $ 
BackButton??5$      $??10,16,675,363q?6>   .??6U   Home6[   ?? 5&   
   -   5         ??Name$ 
CountLabel??5&      $??Center=?6$   $	??Top=?6A   
???  ??$??	0,262,0,0q?6j   6   5(      5)      