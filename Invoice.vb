    Sub GenertePlanID()
        Dim id_temp As String = ""
        sql_gen = "SELECT id FROM table ORDER BY id DESC LIMIT 1"
        cmd_gen = New MySqlCommand(sql_gen, cnn)
        read_gen = cmd_gen.ExecuteReader
        If read_gen.HasRows = False Then
            read_gen.Close()
            id_temp = "P000001"
        Else
            read_gen.Read()
            id_temp = Format(Mid(read_gen("id"), 2, 6) + 1, "P00000#")
        End If
        read_gen.Close()
        txtAutoID.Text = id_temp
    End Sub


'Format(CStr(Mid(dr, 2, 6)) + 1, "E00000#") or Format(CInt(Mid(dr, 2, 6)) + 1, "E00000#")
