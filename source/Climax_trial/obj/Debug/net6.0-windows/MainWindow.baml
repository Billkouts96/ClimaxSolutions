   M S B A M L   `   `   `  ����G  CClimax_trial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Climax_trial.MVVM.ViewModelClimax_trial.MVVM.ViewModel  5   	   +clr-namespace:Climax_trialClimax_trial  5   	   ?$clr-namespace:Climax_trial.MVVM.ViewClimax_trial.MVVM.View  5   	       Climax_trial.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8vm)clr-namespace:Climax_trial.MVVM.ViewModel     5   	   ,localclr-namespace:Climax_trial     5   	   6pages$clr-namespace:Climax_trial.MVVM.View     5   	   $	��600��5
   	   $	��920��6     � WindowStyle$
  None=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      /   )Climax_trial.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 25��5   	   ._�5       �  � ColumnDefinitions 5"      �� 5#      $	��200 �6#   �� 5$       � RowDefinitions 5&      �� 5'      $��25 �6    �� 5(      $��75 �6    �� 5)      .+�5-      �� -   5        $��2��5.      ���#2725._�51      � .+�52      �� $��1��6!   $��Right=�61    �� Orientation$ 
Horizontal=�6M   .+�53      �� -   5        $��25��54      $��25��55      $��_��56      
������ 
�������$
��Bold"�59      $��15(�5:      $��0q�5;      5<      �� 5@      -   5        $��25��5A      $��25��5B      $	��□��5C      
������ 
�������$��DemiBold"�5F      $��0,0,0,0q�5G      $��0q�5H      5I      �� 5K      -   5        $��25��5L      $��25��5M      $��x��5N      
������ 
�������$��DemiBold"�5Q      $��0,0,10,0q�5R      $��0q�5S      5T      5W      5X      5Y      �� 5[      $��Climax��6   $��1��6&   $	��Top=�5\      $
��Left=�5]      
���/���$��26(�5_      $��	26,13,0,0q�6"    J� RenderTransformOrigin$ 1.333,0.342&�65   �� 5`      $��2��6   .+�5a      	� -   5        $#��Πίνακας Ελέγχου��5a      $��50��5b      
�������$��15(�5d         MenuButtonTheme#��[  5e      	 d� 	IsChecked$
	 TrueY�5f      ��5g      �� *DashboardViewCommand+	� 5j      $��
Κόστη��6   $��50��5k      
�������$��15(�5m      #��[  5n      	� 5q      $��
Έσοδα��6   $��50��5r      
�������$��15(�5t      #��[  5u      ��5v      �� *IncomesViewCommand+	� 5x      $��Αποτελέσματα��6   $��50��5y      
�������$��15(�5{      #��[  5|      	� 5~      $%��Καταγραφή Εξόδων��6   $��50��5      
�������$��15(�5�      #��[  5�      ��5�      �� *ExpensesViewCommand+5�      �� 5�      $��2��6   $��1��5�   !   $��10q�5�   !   ��5�   !   �� *CurrentView+5�      5�      5�      