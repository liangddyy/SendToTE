<?php
if ($_FILES["file"]["error"] > 0)
	{
		echo "error";
	}
else
{  
	//$url = "http://localhost/typecho/usr/";
	$url = "http://539go.com/usr/";
	$path = "uploads/".date("Y/m-d/");
	creatdir($path);
	if (file_exists($path . $_FILES["file"]["name"]))
	{
		echo "exists";
	}
	else
	{
		move_uploaded_file($_FILES["file"]["tmp_name"],
		$path . $_FILES["file"]["name"]);
		echo $url . $path . $_FILES["file"]["name"];
	}
}
function creatdir($path)
{
	if(!is_dir($path))
	{
		if(creatdir(dirname($path)))
		{
			mkdir($path,0777);
			return true;
		}
	}
	else
	{
		return true;
	}
}
?>