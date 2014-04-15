﻿using CommandLine;

namespace RabbitHoleNode.Node
{
	public class NodeCreationOptions
	{
		[Option('f', "from", Required = true, HelpText = "Source queue for node.")]
		public string SourceQueue { get; set; }

		[Option('t', "to", Required = true, HelpText = "Destination queue for node.")]
		public string DestinationQueue { get; set; }

		[Option('l', "tasksLimit", DefaultValue = 2, HelpText = "Maximum count of async message processing tasks.")]
		public int MaxTasks { get; set; }

		[Option('n', "name", DefaultValue = null, HelpText = "Node name.")]
		public string NodeName { get; set; }

		[Option('p', "state-notification-period", DefaultValue = 5, HelpText = "Node state notification period in seconds.")]
		public int StateNotificationPeriod { get; set; }

		[Option('s', "service", Required = true, HelpText = "Service class name. Must be in namespace, setted by -namespace.")]
		public string ServiceName { get; set; }

		[Option("namespace", DefaultValue = DefaultNamespace, HelpText = "Service namespace. Defaults to 'MK.Import.Domain.Services'.")]
		public string ServiceNamespace { get; set; }

		[Option("dto-from", Required = true, HelpText = "Type for source DTO.")]
		public string DtoFromType { get; set; }

		[Option("dto-to", Required = true, HelpText = "Type for destination DTO.")]
		public string DtoToType { get; set; }

		private const string DefaultNamespace = "MK.Import.Domain.Services";
	}
}