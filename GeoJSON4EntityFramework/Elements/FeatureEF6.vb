﻿Partial Class Feature

    Public Shared Function FromDbGeometry(inp As System.Data.Entity.Spatial.DbGeometry) As Feature
        Dim f As New Feature

        Select Case inp.SpatialTypeName
            Case "MultiPolygon"
                f.Geometry.Add(MultiPolygon.FromDbGeometry(inp))
            Case "Polygon"
                f.Geometry.Add(Polygon.FromDbGeometry(inp))
            Case "Point"
                f.Geometry.Add(Point.FromDbGeometry(inp))
            Case "MultPoint"
                f.Geometry.Add(MultiPoint.FromDbGeometry(inp))
            Case "GeometryCollection"
                f.Geometry.Add(GeometryCollection.FromDbGeometry(inp))
        End Select

        Return f
    End Function
End Class