<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!DOCTYPE html>
<html>
<head>
<!-- for Bootstrap CSS -->
<link rel="stylesheet" href="/webjars/bootstrap/css/bootstrap.min.css" />
<!-- YOUR own local CSS -->
<link rel="stylesheet" type="text/css" href="/css/style.css">
<!-- For any Bootstrap that uses JS -->
<script src="/webjars/bootstrap/js/bootstrap.min.js"></script>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<header>
		<h1>Customer Name: <c:out value="${name}"></c:out></h1>
		<h3>Item name: <c:out value="${itemName}"></c:out> </h3>
		<h3>Price: $<c:out value="${price}"></c:out> </h3>
		<h3>Description: <c:out value="${description}"></c:out> </h3>
		<h3>Vendor: <c:out value="${vendor}"></c:out> </h3>
	</header>
</body>
</html>