   M S B A M L   `   `   `  ����G  CClimax_trial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Climax_trial.MVVM.ViewClimax_trial.MVVM.View  5      I)clr-namespace:Climax_trial.MVVM.ViewModelClimax_trial.MVVM.ViewModel  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      $    Climax_trial.MVVM.View.Incomes   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Climax_trial.MVVM.View     5      @
view_model)clr-namespace:Climax_trial.MVVM.ViewModel     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5        � DataContext  5      2   ,Climax_trial.MVVM.ViewModel.IncomesViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��250 �6   �� 5      .+�5   
   �� $��0,0,6,0q�6   .+�5      �� 
������$��12,0,0,0q�60   $��14(�6B   
Μήνας5      �� 5      
���   �$��14(�5      $	��192��5      $��41��5      $
��Left=�5      $��10,0,0,0q�5      ��5      �� *EXPENSES_CATEGORIES+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      ��  �� Path$
 Name��� 5       
������$��	10,10,0,0q�60   $��14(�6C   Τύπος Χρέωσης5!       �� 5"      
���   �$��14(�5$      $	��189��5%      $��41��5&      $
��Left=�5'      $��10,0,0,0q�5(      ��5)      �� *EXPENSE_TYPE+$ PropertyChanged=� 5*      �� $
 Type�5,      �� 5-   
   $��260,0,240,0q�6   .+�5.      �� 
������$��0,0,0,0q�60   $��14(�6A   
Τιμή5/      �� 50      
�������$	��180��52      $��10��53      $
��Left=�54      .��56      ��57      �� 58      $ Price�6    �� Mode$ TwoWay=�6+   $ PropertyChanged=�69    �� ValidatesOnDataErrors$
 True��6_   5:      .��5;       5<      �� 5>      
������$��0,20,0,0q�60   $��14(�6B   Αποφορολογητέο5?   !   �� 5@      
�������$	��180��5B      $��10��5C      $��0,0,0,0q�5D      $
��Left=�5E      .��5F      ��5G      �� 5H      $ TaxFree�6   $ TwoWay=�6-   $ PropertyChanged=�6;   $
 True��6a   5J      .��5K       5L      5M      �� 5O   
   $��	500,0,5,0q�6   .+�5P      �� 
������$��0,0,0,0q�60   $��14(�6A   Συντελεστής ΦΠΑ5Q   "   �� 5R      
�������$	��180��5T      $��10��5U      $
��Left=�5V      .��5W      ��5Y      �� 5Z      $	 Tax�6   $ TwoWay=�6)   $ PropertyChanged=�67   $
 True��6]   5\      .��5]       5^      �� 5`      
������$��0,20,0,0q�60   $��14(�6B   Επιστρεπτέο ΦΠΑ5a   !   �� 5b      
�������$	��180��5d      $��10��5e      $��0,0,0,0q�5f      $
��Left=�5g      .��5h      5i      5l      �� 5m   
   $��
0,150,0,50q�6   .+�5o      �� $	��120��5p      $��40��5q      
�������$
��Save��5s      ��5t      �� *SaveExpense+5y      5      5�      