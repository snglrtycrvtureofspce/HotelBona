   M S B A M L   `   `   `  ����F  BKingWilliam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KingWilliamKingWilliam  5   	       KingWilliam.Reserv   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:KingWilliam     5   	   -   5          � Title$  Guestt��5	   	   $	��450��6   $	��800��6%   .��5
      � .+�5   
   � 
������� � ColumnDefinitions 5      �� 5      $
��247* �6#   �� 5      $
��153* �6#    � RowDefinitions 5      �� 5      $��60 �6    �� 5      �� 5      $��60 �6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	GuestGrid��5      $��1��5         AutoGenerateColumns .  $��2��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$) #Номер Бронирования��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6E   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *ReservationID+  5      $ Номер жильца��6)   $ * 6?    6I   �� *	GuestID+  5      $ Номер комнаты��6)   $ * 6@    6J   �� *RoomID+  5       $' !Дата бронирования��6)   $ * 6D    6N   �� *
DateMade+	 �� StringFormat$	 
dd-MM-yyyy��  5!      $ Дата начала��6)   $ * 6>    6H   �� *ReservationStartDate+$	 
dd-MM-yyyy��  5"      $ Дата конца��6)   $ * 6=    6G   �� *ReservationEndDate+$	 
dd-MM-yyyy��5%      �� 5&      -   5        $"��Редактирование��5&      $
��Left=�6.   $��20,0,0,0q�6I   $��2��6[   $��Center=�6h   $��20��6�   $	��130��6�   6�   �� 5'      -   5        $��На главную��5'      $
��Left=�6*   $��	215,0,0,0q�6E   $	��120��6X   $��2��6d   $��Center=�6q   6�   �� 5(      -   5        
 ��Name$
 Poisk��5(      $
��Left=�6%   $��
291,26,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   6�   �� 5)      $��
Поиск��6   $
��Left=�6$   $��
235,22,0,0q�6?   $	��Top=�6S    J� RenderTransformOrigin$ 2.549,-0.407&�6k   �� 5*      -   5        $

 data��5*      $��1��6$   $
��Left=�64   $��44,0,0,0q�6O   $
 Wrap=�6a   $��TextBox��6u   $��Center=�6�   $	��120��6�   6�   (  "System.Windows.Controls.DatePicker  5+      -   5          Name$ dated��5+      $��1��6(   $
��Left=�68   $��	250,0,0,0q�6S   $��Center=�6�   �� 5,      -   5        $��1��5,      $��CheckBox��6'   $
��Left=�6:   $��
196,22,0,0q�6U   $	��Top=�6i   6�   �� 5-      -	   5        $��Обновить��5-      $
��Left=�6(   $��	366,0,0,0q�6C   $��2��6V   $��Center=�6c   $��70��6~   6�   5/      50      51      