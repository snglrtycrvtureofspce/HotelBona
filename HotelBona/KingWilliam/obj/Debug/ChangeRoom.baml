   M S B A M L   `   `   `  ����F  BKingWilliam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KingWilliamKingWilliam  5   	       KingWilliam.ChangeRoom   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:KingWilliam     5   	     � Title$  
ChangeRoom��5   	   $��329.512��6   $��648.644��6-    � WindowStyle$
 None=�6=   .��5	      � .+�5
   
   �� -   5         ��Name$ lblRoomType��5
      $��Тип номера:��6%   $��Center=�6;   $
��Left=�6_   $	��Top=�6z   $��16(�6�   $	��114��6�   $��167,128,0,0q�6�    J� RenderTransformOrigin$ 0.159,0.471&�6�   �� 5   
   -   5         ��Name$ cmbRoomType��5      $
��Left=�6(   $	��Top=�6C   $	��120��6[   $��16(�6g   $��355,132,0,0q�6u   6�   �� 5   
   -   5        $ lblRoomType_Copy��5      $ ��Номер комнаты:��6*   $��Center=�6C   $
��Left=�6g   $	��Top=�6�   $��16(�6�   $	��127��6�   $��175,179,0,0q�6�   �� 5   
   -   5        $ cmbRoomNumber��5      $
��Left=�6*   $	��Top=�6E   $	��120��6]   $��16(�6i   $��355,188,0,0q�6w   �� 5   
   -   5         ��Name$ 	btnSubmit��5      $��Изменить��6$   $
��Left=�67   $	��Top=�6R   $	��121��6j   $��32��6v   ���#4682B4$��18(�6�   ���	#FFF1F1F1$��175,255,0,0q�6�   6�   �� 5   
   -   5        $ 	btnCancel��5      $��Отменить��6$   $
��Left=�67   $	��Top=�6R   $	��120��6j   $��32��6v   ���#4682B4$��18(�6�   ���	#FFF1F1F1$��355,255,0,0q�6�   6�   �� 5   
   -   5        $ lblStartDate��5      $��Дата заезда��6&   $��Center=�6<   $
��Left=�6`   $	��Top=�6{   $��16(�6�   $	��178��6�   $��
134,29,0,0q�6�   �� 5   
   -   5        $ 
lblEndDate��5      $��Дата отъезда��6$   $��Center=�6;   $
��Left=�6_   $	��Top=�6z   $��16(�6�   $	��192��6�   $��
132,77,0,0q�6�   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ dpiStartDate��5      $
��Left=�6+   $	��Top=�6F   $��16(�6^   $	��132��6m   |�.  $��
355,29,0,0q�6�   6�     5   
   -
   5        $ 
dpiEndDate��5      $
��Left=�6)   $	��Top=�6D   $	��132��6\   $��16(�6h   $��32��6w   |�.  $��
355,77,0,0q�6�   6�   5      5      