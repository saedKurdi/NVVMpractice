   M S B A M L   `   `   `  ����?  ;NVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NVVM.Views.WindowsNVVM.Views.Windows  5   	   $    NVVM.Views.Windows.EditCarView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NVVM.Views.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5        $��edit_window��5
   	     � Title$  EditCarView��5   	   $	��450��6   $	��800��6*   .��5      � .+�5   
   �� $	��500��6   $��Center=�6!   $��Center=�6>   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��
5 20 10 20q�62   .+�5      �� $��18(�6   $
��Make��6&   $��70��65   $��Center=�6@   $
��Left=�6[   $��0 0 10 0q�6v   �� 5      $��18(�6j   $	��400��6x   $��Right=�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Enter Make��5      ��5      �� *EditCar.Make+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      5      �� 5      $ 
Horizontal=�6   $��
5 20 10 20q�62   .+�5      �� $��18(�6   $��Model��6&   $��70��66   $��Center=�6A   $
��Left=�6\   $��0 0 10 0q�6w   �� 5      $��18(�6k   $	��400��6y   $��Right=�6�   $ Enter Model��5      ��5      �� *EditCar.Model+$ TwoWay=�$ PropertyChanged=�5      5      �� 5      $ 
Horizontal=�6   $��
5 20 10 20q�62   .+�5      �� $��18(�6   $
��Date��6&   $��70��65   $��Center=�6@   $
��Left=�6[   $��0 0 10 0q�6v   (  "System.Windows.Controls.DatePicker  5      $ 
Enter Date��6u   $��18(�6�   $	��400��6�   $��Right=�6�      SelectedDate 6   �� *EditCar.Date+$ TwoWay=�$ PropertyChanged=�6�   5       �� 5#      $��Center=�6   .+�5$      �� $	��100��6p   $
��SAVE��6|   $��5q�6�   ��6   �� *SaveCommand+��69   ��  �� ElementName$ edit_window��6�   �� 5%      $	��100��6p   $��CANCEL��6|   $��5q�6�   ��6   �� *CancelCommand+��6;   �� $ edit_window��6�   5&      5)      5*      5+      