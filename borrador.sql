use ELAYCAFETERIA;
--agregue esto de Melissa--
CREATE OR ALTER PROCEDURE SPCONTARPEDIDOSMETODOPAGO
AS
BEGIN
    SELECT
        M.nombre,COUNT(P.id_venta) AS Cantidad
    FROM Metodo_pago M
    LEFT JOIN Pedido P
        ON M.id_metodo_pago = P.id_metodo_pago
    GROUP BY M.nombre
END
CREATE OR ALTER PROCEDURE SPMOSTRARPEDIDOSGRAFICO
AS
BEGIN
    SELECT
        P.id_venta AS Pedido,
        C.nombre + ' ' + C.apellido AS Cliente,

        STUFF
        (
            (
                SELECT ', ' + PR.nombre
                FROM Detalle_pedido D
                INNER JOIN Producto PR
                ON D.id_producto=PR.id_producto
                WHERE D.id_venta=P.id_venta
                FOR XML PATH('')
            ),1,2,''
        ) AS Productos,

        P.total,
        M.nombre AS MetodoPago

    FROM Pedido P
    INNER JOIN Cliente C
    ON P.id_cliente=C.id_cliente

    INNER JOIN Metodo_pago M
    ON P.id_metodo_pago=M.id_metodo_pago

    ORDER BY P.id_venta DESC
END