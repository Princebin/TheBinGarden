   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   
   F BTomatoClock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TomatoClock.ControllersTomatoClock.Controllers 5      ?$clr-namespace:TomatoClock.Views.HomeTomatoClock.Views.Home 5      %   TomatoClock.Views.Home.HomeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J FAy.MvcFramework, Version=7.4.0.0, Culture=neutral, PublicKeyToken=null^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35N JAy.MvcFramework.Wpf, Version=7.6.1.3, Culture=neutral, PublicKeyToken=nullJ 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5   
   *controlhttp://www.ayjs.net/controls  5      &ayihttp://www.ayjs.net/behavior  5      c	 _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity 	 5	      h
 dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions 
 5
      6
controller%clr-namespace:TomatoClock.Controllers 
 5      0local$clr-namespace:TomatoClock.Views.Home 
 5        N� Title$  HomeView��5       � DataContext 5      ,  &TomatoClock.Controllers.HomeController  5   
   .��5      � -   5         �Name$
 root��5      .+�5   
   �� $
��Left=�6   $	��Top=�6�   ��60   �� *ActualWidth+ �� ElementName$
 root�� �� Mode$ OneWay=���6m   �� *ActualHeight+$
 root��$ OneWay=�.@�5      �� $��番茄时钟��6   .��5      � ���#C7EDCC3  -Ay.MvcFramework.AyMarkupExtension.GridService   Rows$ Auto Auto Auto Auto *��6,    � 	Resources 5       �� MergedDictionaries �� Source�� 5       5      �� 5   "   $\ Vpack://application:,,,/TomatoClock;component/Contents/Styles/Tomato/CheckboxStyle.xaml?�65   %    5      .+�5!      �� 	 �� Orientation$	 
Horizontal=�6!   $��
10,20,0,10q�6:   $��0��6N   .+�5"      �� -   5        $��Checker1��5"   #      SliderCheckBox#���   63   $��10,0,0,0q�6�   ��6\   �� *WindowsAutomatically+$ TwoWay=�:  4Ay.MvcFramework.AyMarkupExtension.MvcRouteCollection
   Routes
 5#      3  -Ay.MvcFramework.AyMarkupExtension.RouteSetter  5$   "      Event$ Click��6M      Action 6.   �� *StartTomato+6]   5&      �� 5'      -   5         ��Name$ checkboxvalue��5'       $��10,0,0,0q�67   $��Arial Black)�6j   $��24(�6�   ��6I   �� *Model.On_off+6�   5(      �� 5)      $	 
Horizontal=�6!   $��
10,20,0,10q�6:   $��1��6N   .+�5*      �� $��10,0,0,0q�6    $��Arial Black)�62   $��22(�6K   $��提醒频率��6Y   �� 5+      $��10,0,0,0q�6    $��Arial Black)�62   $��22(�6K   $��每隔��6Y   �� 5,      -   5         ��Name$ 
Tomatotime��5,   "   $��10,0,0,0q�66   $��Arial Black)�6H   $��22(�6a   $��70��6o   ��6z   �� *Model.TomatoTime+�� 5-      $��10,0,0,0q�6    $��Arial Black)�62   $��22(�6K   $��分钟��6Y   �� 5.      $��20,0,0,0q�6    $��Arial Black)�62   $��22(�6K   $��休息��6Y   �� 5/      -   5        $ Resttime��5/      $��10,0,0,0q�60   $��Arial Black)�6B   $��22(�6[   $��70��6i   ��6t   �� *Model.RestTime+�� 50      $��10,0,0,0q�6   $��Arial Black)�6.   $��22(�6G   $��分钟��6U   51      �� 52      $	 
Horizontal=�6!   $��
10,20,0,10q�6:   $��2��6N   .+�53      �� $��10,0,0,0q�6    $��Arial Black)�62   $��22(�6K   $��下次提醒时间��6Y   �� 54      -   5        $ 	AlertTime��54       $��10,0,0,0q�63   $��Arial Black)�6E   $��22(�6^   $	��100��6�   {�.  ��6l   �� *Model.AlertTime+6�   ,  &Ay.Framework.WPF.Controls.AyTextButton  55         Text$ 刷新提醒时间��6/   $��0q�6=   $��15,0,0,0q�6Q   
 56        57   "   $ Click��6J    6.   �� *
ReshTime+6Z   59      5:      �� 5;      $��20q�6!   $��3��6-   .+�5<      �� $��3q�6!   
���   ���5=      �� 5>   "    �� 
StartPoint$ 0.5,0&�66    �� EndPoint$ 0.5,1&�6I   .��5?   &   �  � Offset$ 0Q�63    � Color$ White��6>   � 5@   &   $	 0.5Q�63   $
 Gold��6@   5A   #   ._�5C      r� -   5        $��mediaElement��5C   C   $��40��6+   $	��450��67    r� Volume$	 0.5Q�5D       r� LoadedBehavior$ Manual=�6$   5E      �� 5F      $	 
Horizontal=�6%   $��40��6>   $��Center=�6J   .+�5G      �� -   5         ��Name$ openBtn��5G   %   $��	Open File��66     btnStyle#��[ 5H      �� 5I      -	   5        $ playBtn��5I   %   $
��Play��66   #��[ 5J      �� 5K      -
   5        $ stopBtn��5K   %   $
��Stop��66   #��[ 5L      �� 5M      -   5        $ backBtn��5M   %   $
��Back��66   #��[ 5N      �� 5O      -   5        $ 
forwardBtn��5O   %   $��Forward��69   #��[ 5P      5Q      �� 5R      $	 
Horizontal=�6%   $��Center=�6>   $��5q�6[   .+�5S      �� $��Volume��6(   
��� ���66   �� 5T      -   5         ��Name$ volumeSlider��5T   %    � Minimum$ 0Q�6;    � Maximum$ 1Q�6G    � Value$	 0.5Q�6S   $	��200��6_   5U      5V      5W      5X      �� 5Y      $��闹钟��6   .��5Z      � ���#C7EDCC6   5[      5\      5^      5_      