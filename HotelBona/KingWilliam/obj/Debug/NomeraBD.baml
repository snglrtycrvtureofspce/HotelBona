   M S B A M L   `   `   `  ����F  BKingWilliam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KingWilliamKingWilliam  5   	       KingWilliam.NomeraBD   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:KingWilliam     5   	   -   5          � Title$  NomeraBD��5	   	   $	��450��6   $	��800��6'   .��5
      � .+�5   
   � 
������� � ColumnDefinitions 5      �� 5      $
��247* �6#   �� 5      $
��153* �6#    � RowDefinitions 5      �� 5      $��60 �6    �� 5      �� 5      $��60 �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      .+�5      �� $0��*Введите номер комнаты: ��6   $��16(�5      6-   �� 5      -   5        $��Poisk��5      $	��100��5      $��16(�5      5      5!      &   System.Windows.Controls.DataGrid  5#      -   5          Name$ RoomGrid��5%      $��1��5#         AutoGenerateColumns .  $��2��5&         Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер Комнаты��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6@   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6J   �� *RoomID+  5)      $ Тип��6)   $ * 66   	 6@   �� *
RoomTypeID+  5*      $ Цена за ночь��6)   $ * 6?   	 6I   �� *Cost+  5+      $ Этаж��6)   $ * 67   	 6A   �� *	RoomFloor+5.      �� 5/      -   5        $\��VПроверить свободен ли номер в определнную дату��5/      $
��Left=�6N   $��45,0,0,0q�6i   $��2��6{   $��Center=�6�   $	��306��6�   6�   �� 50      -   5        $��Люкс��50      $
��Left=�6&   $��
456,15,0,0q�6A   $	��Top=�6U   $��2��6�   �� 51      -   5        $��Двухместный��51      $
��Left=�6-   $��
456,35,0,0q�6H   $	��Top=�6\   
 J� RenderTransformOrigin$
 -4.154,-1.336&�6t   $��2��6�   $	��100��6�   6�   �� 52      -   5        $��Одиночный��52      $
��Left=�6+   $��	28,15,0,0q�6F   $	��Top=�6Y   $��1��6q   6�   �� 53      -   5        $��На главную��53      $
��Left=�6*   $��	400,0,0,0q�6E   $��2��6X   $��Center=�6e   6�   �� 54      -	   5        $��1��54      $)��#Отчет о топ-номерах��6%   $
��Left=�6C   $��	10,22,0,0q�6^   $��2��6q   $	��Top=�6�   56      57      58      