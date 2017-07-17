// Пример прикольного квадрата в редакторе C:
// PS: тут не оптимизировано перестроение, надо кешировать а не каждый фрэйм, разумеется.
        var target = this.target as GoodPhotoMoment;
        var pos = target.transform.position;

        var verts = new[]{
            pos + target.GoodShotPoints[0],
            pos + target.GoodShotPoints[1],
            pos + target.GoodShotPoints[2],
            pos + target.GoodShotPoints[3],
        };
        Handles.DrawSolidRectangleWithOutline(verts, new Color(0.5f, 1, 0.5f, 0.1f), new Color(0, 0, 0, 1));

        int i = 0;

        foreach (var vert in verts)
        {
            var newpos = Handles.FreeMoveHandle(vert, Quaternion.identity, 0.05f, Vector3.zero, Handles.ConeHandleCap);
            newpos.z = vert.z;
            newpos -= pos;

            target.GoodShotPoints[i] = newpos;
            i++;
        }
