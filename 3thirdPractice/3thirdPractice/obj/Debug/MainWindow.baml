   M S B A M L   `   `   `  ����I  E3thirdPractice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:_3thirdPractice_3thirdPractice  5           _3thirdPractice.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:_3thirdPractice     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  Pomodoro Timer��5      $	��800��5	      $	��450��5
       � Icon$ images/icon.jpg��5      .��5      � 
��� ��� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�5      $��Center=�5      $��Center=�5      $
��0,20q�5      .+�5      �� -   5         ��Name$ StartPauseButton��5      $	��150��5      $��60��5       $��10q�5!      
��� ���$��0q�5#      $��
Старт��5%      $��20(�5&      �� 5(      -   5        $ ResetButton��5)      $	��150��5*      $��60��5+      $��10q�5,      
��� ���$��0q�5.      $��
Сброс��50      $��20(�51      52      �� 55   
   -   5         ��Name$ CyclesCountText��57      $��1��56      $��Center=�58      $��Center=�59      $��24(�5:      $8��2Количество завершённых дел��5;      �� 5>   
   $��2��6   $��Center=�5?      $��Center=�5@      $��0,0,0,40q�5A      .+�5B      �� -   5        $ 
StatusText��5C      $��0,0,0,10q�5D      $��Center=�5E      $��30(�5F      $��Работай��5G      �� 5I      -   5        $ 	TimerText��5J      $��Center=�5K      $��80(�5L      $��
Время��5M      5N      5O      5P      